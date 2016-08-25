using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnPack
{
    public class EnumField:Field
    {
        private Dictionary<int,string> _enumItem;
        public EnumField(string name, int offset, int len)
            : base(name, offset, len)
        {
            this.Type = FieldType.EnumField;
            _enumItem = new Dictionary<int, string>();
        }

        public void AddItem(int value,string name )
        {
            if (_enumItem.ContainsKey(value))
            {
                throw new Exception(string.Format("枚举值{0}重复"));
            }
            _enumItem.Add(value, name);
        }

        public string GetItemNameByValue(int value)
        {
            if (_enumItem.ContainsKey(value))
            {
                return _enumItem[value];
            }
            return "未定义";
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}({2})", Name, GetItemNameByValue(Value), Value);
        }
    }
}
