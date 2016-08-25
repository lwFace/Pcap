using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnPack
{
    public class FixDataField:Field
    {        
        public FixDataField(string name, int offset, int len):base(name, offset, len)
        {
            this.Type = FieldType.FixDataField;
        }

        public override string ToString()
        {
            return string.Format("{0} : 0x{1:X2}({1})",Name,Value);
        }
    }
}
