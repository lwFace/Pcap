using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace PacapAnalytics
{

    unsafe public sealed class PacapReader : FileStream
    {
        public PcapFileHeader PcapHeader { get; private set; }
        public PacapReader(string fileName)
            : base(fileName, FileMode.Open, FileAccess.Read)
        {
            byte[] buff = new byte[sizeof(PcapFileHeader)];
            int nReadSize = this.Read(buff, 0, sizeof(PcapFileHeader));
            if (nReadSize != sizeof(PcapFileHeader))
            {
                throw new Exception("非法的抓包文件!");
            }
            fixed (byte* ptr = buff)
            {
                this.PcapHeader = *((PcapFileHeader*)ptr);
            }
        }
        unsafe public List<PacapData> Parse()
        {
            List<PacapData> pacapDataList = new List<PacapData>();
            while (this.Position != this.Length)
            {
                byte[] PktHeaderBuffer = new byte[sizeof(PacapPacketHeader)];
                this.Read(PktHeaderBuffer, 0, sizeof(PacapPacketHeader));
                fixed (byte* pktPtr = PktHeaderBuffer)
                {
                    PacapPacketHeader* pktHeader = (PacapPacketHeader*)pktPtr;
                    byte[] data = new byte[pktHeader->Len];
                    int nReadCount = 0;
                    while (nReadCount < pktHeader->Len)
                    {
                        nReadCount += this.Read(data, 0, (int)(pktHeader->Len - nReadCount));
                    }
                    fixed (byte* enterPtr = data)
                    {
                        EthernetHeader* etherHeader = (EthernetHeader*)enterPtr;
                        byte* ipPtr = enterPtr + sizeof(EthernetHeader);
                        IPHeader* header = (IPHeader*)ipPtr;
                        int protocol = header->ProtocolType;
                        PacapData pData = null; 
                        switch ((ProtocolType)header->ProtocolType)
                        {
                            //case ProtocolType.TCP:
                            //    pData = new TcpData(); 
                            //    break;
                            case ProtocolType.UDP:
                                pData = new UdpData(); 
                                break;
                        }
                        if (pData != null)
                        {
                            int offset = 0;// sizeof(EthernetHeader) + pData.HeaderLen;
                            pData.IPHeader = *header;
                            pData.EthernetHeader = *etherHeader;
                            pData.PacketHeader = *pktHeader;
                            pData.Fill(data, offset, (int)(pktHeader->Len - offset));
                            pacapDataList.Add(pData);
                        }
                    }
                }
            }
            return pacapDataList;
        }
    }
}
