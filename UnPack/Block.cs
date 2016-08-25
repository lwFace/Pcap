using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnPack
{
    public class Block
    {
        List<Field> _fields;
        public string Name;
        public int Offset;
        public int Length;
        public Block(string name, int offset, int length)
        {
            _fields = new List<Field>();
            Name = name;
            Offset = offset;
            Length = length;
        }

        public void AddField(Field field)
        {
            try
            {
                _fields.Add(field);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Field> GetFields()
        {
            return _fields;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
