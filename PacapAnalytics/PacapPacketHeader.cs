using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace PacapAnalytics
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PacapPacketHeader
    {
        /// <summary>
        ///  8字节 抓包时间 4字节表示秒数，4字节表示微秒数
        /// </summary>
        public Timestamp Ts;
        /// <summary>
        /// 当前数据区的长度，即抓取到的数据帧长度
        /// </summary>
        public uint CapLen;
        /// <summary>
        /// 离线数据长度：网络中实际数据帧的长度，一般不大于caplen，多数情况下和Caplen数值相等
        /// </summary>
        public uint Len; 
    }
}
