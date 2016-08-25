using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnPack
{
    public enum FieldType { FixDataField, EnumField };
    public class Field
    {
        public string Name;
        public int Offset;
        public int Length;
        public FieldType Type;
        public int Value;
        public Field()
        {

        }
        public Field(string name, int offset, int length)
        {
            Name = name;
            Offset = offset;
            Length = length;
        }
    }
}
