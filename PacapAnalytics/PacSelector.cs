using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacapAnalytics
{
    public class PacSelector
    {
        public int Length { get; set; }
        public int Offset { get; set; }
       public PacSelector(int offset,int len)
        {
            Length = len;
            Offset = offset;
        }
    }
}
