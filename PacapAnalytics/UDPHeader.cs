using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacapAnalytics
{
    public struct UDPHeader
    {
        /// <summary>
        /// 源端口
        /// </summary>
        public ushort SrcPort;
        /// <summary>
        /// 目的端口
        /// </summary>
        public ushort DestPort;
        /// <summary>
        /// udp包长度
        /// </summary>
        public ushort Length;
        /// <summary>
        /// 校验和
        /// </summary>
        public ushort CheckSum;
    }
}
