using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace PacapAnalytics
{ 
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Timestamp
    {
        /// <summary>
        /// 时间戳高位，精确到seconds 
        /// </summary>
        public uint Timestamp_S;
        /// <summary>
        /// 时间戳低位，精确到microseconds 
        /// </summary>
        public uint Timestamp_MS;
    }
}
