using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace PacapAnalytics
{
    public abstract class PacapData
    {
        IPEndPoint source = null;
        IPEndPoint dest = null;
        protected abstract int SourcePort { get; }
        protected abstract int DestPort { get; }
        public IPEndPoint Source
        {
            get
            {
                if (source == null)
                {
                    source = new IPEndPoint(new IPAddress(BitConverter.GetBytes(IPHeader.SrcIP)), SourcePort);
                }
                return source;
            }
        }
        public IPEndPoint Dest
        {
            get
            {
                if (dest == null)
                {
                    dest = new IPEndPoint(new IPAddress(BitConverter.GetBytes(IPHeader.DestIP)), DestPort);
                }
                return dest;
            }
        }
        public ProtocolType ProtocolType
        {
            get
            {
                return (ProtocolType)this.IPHeader.ProtocolType;
            }
        }
        public byte[] Data { get; set; }

        public IPHeader IPHeader { get; set; }

        public abstract int HeaderLen { get; }
        public EthernetHeader EthernetHeader { get; set; }

        public PacapPacketHeader PacketHeader { get; set; }
        public abstract void Fill(byte[] buffer, int offset, int len);
        public string ToString(Encoding encoding)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("From:{0}//{1} To:{0}//{2}{3}", this.ProtocolType, this.Source, this.Dest, Environment.NewLine);
            sb.AppendLine();
            if (this.Data != null && this.Data.Length > 0)
            {
                sb.AppendLine(encoding.GetString(this.Data));
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
