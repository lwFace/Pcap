using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PacapAnalytics;
using Be.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using UnPack;

namespace RDCHelper
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        BindingList<BoundPacket> packetList = new BindingList<BoundPacket>();
        Packet RDCPacket;
        public FrmMain()
        {
            InitializeComponent();
            this.gridControlPac.DataSource = packetList;
            RDCPacket = new Packet(@"E:\Workspace\GitHub\Pcap\PakcetDef.xml");
            gridViewPac.Columns["Tag"].Visible = false;
        }

        private void menuOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "ICD文件(*.pcap)|*.pcap|所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                using (PacapReader reader = new PacapReader(fileName))
                {
                    DevExpress.Utils.WaitDialogForm _waitForm = new DevExpress.Utils.WaitDialogForm("加载数据....", "请耐心等待...");
                    _waitForm.Show();
                    try
                    {
                        List<PacapData> dataList = reader.Parse();
                        foreach (PacapData data in dataList)
                        {
                                packetList.Add(new BoundPacket(data));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 
                    _waitForm.Hide();
                }
            }
        }

        private void gridViewPac_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            PacapData pac = (PacapData)this.gridViewPac.GetRowCellValue(this.gridViewPac.FocusedRowHandle, this.gridViewPac.Columns["Tag"]);
            int dataLength = pac.Data.Length;
            byte[] array = new byte[dataLength];
            byte[] recvData = pac.Data;
            Buffer.BlockCopy(recvData, 0, array, 0, dataLength);
            DynamicByteProvider provider = new DynamicByteProvider(array);
            this.hexBoxPac.ByteProvider = provider;
            UpdateTreeList(treeListPac, pac);
        }
        #region 更新树列表
        private void UpdateTreeList(TreeList treeList, PacapData packet)
        {
            treeList.ClearNodes();

            ParseEthernet(treeList, packet);
            ParseInternetProtocal(treeList, packet);
            ParseUDP(treeList, packet);
            ParseApplication(treeList, packet);
        }

        private void ParseApplication(TreeList treeList, PacapData packet)
        {
            int payloadLen = packet.Data.Length-42;
            TreeListNode DataNode = treeList.AppendNode(new object[] { string.Format("Payload ({0} bytes)", payloadLen )}, -1);
            PacSelector DataSel = new PacSelector(42, payloadLen);
            DataNode.Tag = DataSel;
            RDCPacket.Parse(packet.Data, 42,packet.Data.Length-42);
            foreach (var block in RDCPacket.GetBlocks())
            {
                TreeListNode bNode = DataNode.Nodes.Add(new object[] { block.ToString() });
                PacSelector bSel = new PacSelector(42 + block.Offset, block.Length);
                bNode.Tag = bSel;
                foreach (var field in block.GetFields())
                {
                    int fOffset = block.Offset + field.Offset / 8;
                    int fLen =  field.Length / 8;
                    if (field.Length % 8 != 0)
                    {
                        fLen = field.Length / 8 + 1;
                    }
                   
                    TreeListNode fNode = bNode.Nodes.Add(new object[] { field.ToString() });
                    PacSelector fSel = new PacSelector(42 + fOffset, fLen);
                    fNode.Tag = fSel;
                }              
            }
            DataNode.ExpandAll();
        }

        private void ParseInternetProtocal(TreeList treeList, PacapData packet)
        {
            /*Internet Protocal*/
            TreeListNode IPNode = treeList.AppendNode(new object[] { "Internet Protocal" }, -1);
            PacSelector IPSel = new PacSelector(14, 20);
            IPNode.Tag = IPSel;

            TreeListNode versionNode = IPNode.Nodes.Add(new object[] { "版本： " + (packet.IPHeader.HeadLengthVersion >> 4).ToString() });
            TreeListNode ipLenNode = IPNode.Nodes.Add(new object[] { "IP头长度： " + ((packet.IPHeader.HeadLengthVersion & 0xf) * 4).ToString() + " bytes" });
            PacSelector versionSel = new PacSelector(14, 1);
            versionNode.Tag = versionSel;
            ipLenNode.Tag = versionSel;

            TreeListNode tosNode = IPNode.Nodes.Add(new object[] { string.Format("服务类型： 0x{0:X2}", packet.IPHeader.TOS) });
            PacSelector tosSel = new PacSelector(15, 1);
            tosNode.Tag = tosSel;

            TreeListNode totalLenNode = IPNode.Nodes.Add(new object[] { string.Format("总长度： {0}", packet.IPHeader.TotalLength) });
            PacSelector totalLenSel = new PacSelector(16, 2);
            totalLenNode.Tag = totalLenSel;

            TreeListNode idNode = IPNode.Nodes.Add(new object[] { string.Format("报文标识： 0x{0:X2}({0})", packet.IPHeader.Sequence) });
            PacSelector idSel = new PacSelector(18, 2);
            idNode.Tag = idSel;

            TreeListNode flagNode = IPNode.Nodes.Add(new object[] { string.Format("标志： 0x{0:X2}", packet.IPHeader.FragOffset >> 13) });
            PacSelector flagSel = new PacSelector(20, 1);
            flagNode.Tag = flagSel;

            TreeListNode offsetNode = IPNode.Nodes.Add(new object[] { string.Format("偏移： {0}", packet.IPHeader.FragOffset & 0xE) });
            PacSelector offsetSel = new PacSelector(20, 2);
            offsetNode.Tag = offsetSel;

            TreeListNode ttlNode = IPNode.Nodes.Add(new object[] { string.Format("TTL： {0}", packet.IPHeader.TTL) });
            PacSelector ttlSel = new PacSelector(22, 1);
            ttlNode.Tag = ttlSel;

            TreeListNode protocalNode = IPNode.Nodes.Add(new object[] { string.Format("协议类型： {1}(0x{0:X2})", packet.IPHeader.ProtocolType, packet.ProtocolType) });
            PacSelector protocalSel = new PacSelector(23, 1);
            protocalNode.Tag = protocalSel;

            TreeListNode ipChecklNode = IPNode.Nodes.Add(new object[] { string.Format("校验和： 0x{0:X4}", packet.IPHeader.Checksum) });
            PacSelector ipCheckSel = new PacSelector(24, 2);
            ipChecklNode.Tag = ipCheckSel;

            TreeListNode ipSourceNode = IPNode.Nodes.Add(new object[] { string.Format("源IP： {0}", packet.Source.Address) });
            PacSelector ipSourceSel = new PacSelector(26, 4);
            ipSourceNode.Tag = ipSourceSel;

            TreeListNode ipDstNode = IPNode.Nodes.Add(new object[] { string.Format("目的IP： {0}", packet.Dest.Address) });
            PacSelector ipDstSel = new PacSelector(30, 4);
            ipDstNode.Tag = ipDstSel;
        }

        private void ParseUDP(TreeList treeList, PacapData packet)
        {
            /*UDP Header*/
            TreeListNode UDPNode = treeList.AppendNode(new object[] { "User Datagram Protocal" }, -1);
            PacSelector UDPSel = new PacSelector(34, 8);
            UDPNode.Tag = UDPSel;

            TreeListNode srcPortNode = UDPNode.Nodes.Add(new object[] { string.Format("源端口： {0}", packet.Source.Port) });
            PacSelector srcPortSel = new PacSelector(34, 2);
            srcPortNode.Tag = srcPortSel;

            TreeListNode dstPortNode = UDPNode.Nodes.Add(new object[] { string.Format("目的端口： {0}", packet.Dest.Port) });
            PacSelector dstPortSel = new PacSelector(36, 2);
            dstPortNode.Tag = dstPortSel;

            ushort udpLen = ((UdpData)packet).UdpHeader.Length;
            TreeListNode udpLenNode = UDPNode.Nodes.Add(new object[] { string.Format("长度： {0}", ((udpLen & 0xFF) << 8) + (udpLen >> 8)) });
            PacSelector udpLenSel = new PacSelector(38, 2);
            udpLenNode.Tag = udpLenSel;

            TreeListNode udpCheckNode = UDPNode.Nodes.Add(new object[] { string.Format("校验和： 0x{0:X4}", ((UdpData)packet).UdpHeader.CheckSum) });
            PacSelector udpCheckSel = new PacSelector(40, 2);
            udpCheckNode.Tag = udpCheckSel;
        }

        private void ParseEthernet(TreeList treeList, PacapData packet)
        {
            /*Ethernet II*/
            TreeListNode ethNode = treeList.AppendNode(new object[] { "Ethernet II" }, -1);//Nodes.Add("Ethernet II");//
            PacSelector ethSel = new PacSelector(0, 14);
            ethNode.Tag = ethSel;

            TreeListNode dstMacNode = ethNode.Nodes.Add(new object[] { packet.DstMac() });
            PacSelector dstMacSel = new PacSelector(0, 6);
            dstMacNode.Tag = dstMacSel;

            TreeListNode srcMacNode = ethNode.Nodes.Add(new object[] { packet.SrcMac() });
            PacSelector srcMacSel = new PacSelector(6, 6);
            srcMacNode.Tag = srcMacSel;

            TreeListNode ethTypeNode = ethNode.Nodes.Add(new object[] { packet.EthernetType() });
            PacSelector ethTypeSel = new PacSelector(12, 2);
            ethTypeNode.Tag = ethTypeSel;
        }
        #endregion
        private void treeListPac_Click(object sender, EventArgs e)
        {
            PacSelector selector = treeListPac.FocusedNode.Tag as PacSelector;
            hexBoxPac.Select(selector.Offset, selector.Length);
        }
    }
}