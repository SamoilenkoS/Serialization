using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    public class Item
    {
        public int Key { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return $"{nameof(Key)} = {Key}, {nameof(Value)} = {Value}";
        }
    }
}
