using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacapAnalytics
{
    unsafe public sealed class TcpData : PacapData
    {
        public TcpHeader TcpHeader { get; set; }
        protected override int SourcePort
        {
            get { return ((this.TcpHeader.SrcPort & 0xFF) << 8) + (this.TcpHeader.SrcPort >> 8); }
        }
        unsafe public override int HeaderLen
        {
            get { return sizeof(TcpHeader); }
        }
        protected override int DestPort
        {
            get { return ((this.TcpHeader.DestPort & 0xFF) << 8) + (this.TcpHeader.DestPort >> 8); }
        }
        public override void Fill(byte[] buffer, int offset, int len)
        {
            fixed (byte* ptr = &buffer[offset + 34])
            {
                this.TcpHeader = *(TcpHeader*)ptr;
              //  this.Data = new byte[len - sizeof(TcpHeader)];
              //  Array.Copy(buffer, offset + sizeof(TcpHeader), this.Data, 0, this.Data.Length);
                this.Data = new byte[len];
                Array.Copy(buffer, offset , this.Data, 0, len);
            }
        }
    }
}
