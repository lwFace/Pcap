using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace PacapAnalytics
{
    public sealed class UdpData : PacapData
    {
        public UDPHeader UdpHeader { get; set; }
        unsafe public override int HeaderLen
        {
            get { return sizeof(UDPHeader); }
        }
        protected override int SourcePort
        {
            get { return this.UdpHeader.SrcPort; }
        }

        protected override int DestPort
        {
            get { return this.UdpHeader.DestPort; }
        }
        unsafe public override void Fill(byte[] buffer, int offset, int len)
        {
            fixed (byte* ptr = &buffer[offset])
            {
                this.UdpHeader = *(UDPHeader*)ptr;
                this.Data = new byte[len - sizeof(UDPHeader)];
                Array.Copy(buffer, offset + sizeof(UDPHeader), this.Data, 0, this.Data.Length);
            }
        }
    }
}
