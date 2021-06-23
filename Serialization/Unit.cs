using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    public class Unit
    {
        public int Id { get; set; }
        public List<Item> Items { get; private set; }
        public Unit() => Items = new List<Item>();

        public void Add(Item item)
            => Items.Add(item);

        public bool RemoveFirst(Item item)
            => Items.Remove(item);

        public bool RemoveAll(Item item)
            => Items.RemoveAll(x => x == item) != 0;

        public override string ToString()
        {
            var stringBuilder = new StringBuilder($"{nameof(Id)} = {Id}{Environment.NewLine}{nameof(Items)}{Environment.NewLine}");
            foreach (var item in Items)
            {
                stringBuilder.Append($"{item}{Environment.NewLine}");
            }

            return stringBuilder.ToString();
        }
    }
}
