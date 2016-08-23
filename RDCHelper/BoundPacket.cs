using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PacapAnalytics;

namespace RDCHelper
{
    public class BoundPacket
    {
        public ProtocolType Type { get; set; }
        public int Length { get; set; }
        public System.Net.IPEndPoint Source { get; set; }
        public System.Net.IPEndPoint Dest { get; set; }
        public byte[] Payload;
        public object Tag{get;set;}
        public BoundPacket(PacapData pac)
        {
            Tag = pac;
            Payload = pac.Data;
            Source = pac.Source;
            Dest = pac.Dest;
            Type = pac.ProtocolType;
            Length = Payload.Length ;
        }
    }
}
