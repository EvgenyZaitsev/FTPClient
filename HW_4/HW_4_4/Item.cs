using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_4
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Item(string name, double price)
        {
                this.Name = name;
                this.Price = price;
        }
        public override bool Equals(object obj)
        {
            Item i = obj as Item;
            if ((object)i == null)
            {
                return false;
            }
            return (this.Name == i.Name) && (this.Price == i.Price);
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Price.GetHashCode();
        }
    }
}
