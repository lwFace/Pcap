using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace PacapAnalytics
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct IPHeader
    {
        /// <summary>
        /// 4位首部长度 +4位版本号
        /// </summary> 
        public byte HeadLengthVersion;
        /// <summary>
        /// 8位服务类型 
        /// </summary> 
        public byte TOS;
        /// <summary>
        /// 16位总长度
        /// </summary> 
        public ushort TotalLength;
        /// <summary>
        /// 16位标识，每发送一个数据包就会加一
        /// </summary> 
        public ushort Sequence;
        /// <summary>
        /// 3位标志位 +13位偏移量
        /// </summary> 
        public ushort FragOffset;
        /// <summary>
        /// 8位生存时间
        /// </summary> 
        public byte TTL;
        /// <summary>
        ///  8位协议类型
        /// </summary> 
        public byte ProtocolType;
        /// <summary>
        /// 16位校验和
        /// </summary> 
        public ushort Checksum;
        /// <summary>
        /// 32位源ip
        /// </summary> 
        public uint SrcIP;
        /// <summary>
        /// 32位目的ip
        /// </summary> 
        public uint DestIP;

    }
}
