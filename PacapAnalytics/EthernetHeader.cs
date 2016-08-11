using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace PacapAnalytics
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    unsafe public struct EthernetHeader
    {
        /// <summary>
        /// 目标Mac地址
        /// </summary>
        public fixed byte DestMacAddress[6];
        /// <summary>
        /// 来源Mac地址
        /// </summary>
        public fixed byte SourceMacAddress[6];
        /// <summary>
        /// 链路类型
        /// </summary>
        public ushort EthernetType;
    }
}
