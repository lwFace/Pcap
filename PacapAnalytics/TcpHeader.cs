using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace PacapAnalytics
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TcpHeader
    {
        /// <summary>
        /// 16位源端口
        /// </summary>
        public ushort SrcPort;
        /// <summary>
        /// 16位目标端口
        /// </summary>
        public ushort DestPort;
        /// <summary>
        /// 32位序列号
        /// </summary>
        public uint Sequence;
        /// <summary>
        /// 32位确认号
        /// </summary>
        public uint Confirm;
        /// <summary>
        /// 4为HeaderLength+6为保留+6为标志位
        /// </summary>
        public ushort FlagReservedHeaderLength; 
        /// <summary>
        /// 16位窗口大小
        /// </summary>
        public ushort WindowSize;
        /// <summary>
        /// 16位TCP校验和
        /// </summary>
        public ushort CheckSum;
        /// <summary>
        /// 16位紧急指针
        /// </summary>
        public ushort Img;
    }
}
