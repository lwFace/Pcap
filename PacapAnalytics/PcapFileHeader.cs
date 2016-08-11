using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace PacapAnalytics
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PcapFileHeader
    {
        /// <summary>
        ///  pcap文件标识 目前为“d4 c3 b2 a1”
        /// </summary>
        public uint Magic;
        /// <summary>
        ///  2字节主版本号
        /// </summary>
        public ushort MajorVersion;
        /// <summary>
        /// 2字节次版本号 
        /// </summary>
        public ushort MinorvVersion;
        /// <summary>
        /// 4字节时区修正
        /// </summary>
        public uint ThisZone;
        /// <summary>
        /// 4字节精确时间戳
        /// </summary>
        public uint SigFigs;
        /// <summary>
        /// 4字节抓包最大长度如果要抓全
        /// </summary>
        public uint SnapLen;
        /// <summary>
        /// 4字节链路类型    一般都是1：ethernet
        /// </summary>
        public uint LinkType; 
    }
}
