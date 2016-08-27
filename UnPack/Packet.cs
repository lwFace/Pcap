using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace UnPack
{
    public class Packet
    {
        private List<Block> _blocks;
        public Packet(string fileName)
        {
            _blocks = new List<Block>();
           XmlParse(fileName);
        }
        public List<Block> GetBlocks()
        {
            return _blocks;
        }

        private void XmlParse(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode rootNode = doc.SelectSingleNode("Packet");//得到根节点Target
            foreach (XmlNode blockNode in rootNode.ChildNodes)
            {
                XmlElement blockElement = (XmlElement)blockNode;
                int bOffset = int.Parse(blockElement.GetAttribute("offset"));
                int bLen = int.Parse(blockElement.GetAttribute("length"));
                string bName = blockElement.GetAttribute("name");
                Block block = new Block(bName,bOffset,bLen);
                foreach (XmlNode fieldNode in blockNode.ChildNodes)
                {
                    Field field = null;
                    XmlElement fieldElement = (XmlElement)fieldNode;
                    int fOffset = int.Parse(fieldElement.GetAttribute("offset"));
                    int fLen = int.Parse(fieldElement.GetAttribute("length"));
                    string fName = fieldElement.GetAttribute("name");
                    string fType = fieldElement.GetAttribute("type");
                    if (fType.Equals("fixData"))
                    {
                        field = new FixDataField(fName, fOffset, fLen);
                    }
                    else if (fType.Equals("enum"))
                    {
                        field = new EnumField(fName, fOffset, fLen);
                        foreach (XmlNode itemNode in fieldNode.ChildNodes)
                        {
                            XmlElement itemElement = (XmlElement)itemNode;
                            string itemName = itemElement.GetAttribute("name");
                            int itemVal = int.Parse(itemElement.GetAttribute("value"));
                            ((EnumField)field).AddItem(itemVal, itemName);
                        }
                    }
                    else
                    {
                        throw new Exception("Unknown field type : " + fType);
                    }
                    block.AddField(field);
                }
                _blocks.Add(block);
            }
        }

        public void Parse(byte[] data,int offset,int length)
        {
            foreach (var block in _blocks)
            {
                foreach (var field in block.GetFields())
                {
                    int mask = 0;
                    for (int j = 0; j < field.Length; j++)
                    {
                        mask |= (1 << j);
                    }
                    if (offset + block.Offset > data.Length)
                    {
                        throw new Exception("数据偏移大于数据长度！");
                    }
                    int val = System.BitConverter.ToInt32(data, offset+block.Offset); 
                  
                    field.Value = (val>>field.Offset) & mask;
                    
                }
            }
        }
    }
}
