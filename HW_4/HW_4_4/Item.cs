using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_4
{
    public class Item
    {
        ListOfItems lof;
        public string Name { get; set; }
        public double Price { get; set; }
        public Item(ListOfItems lof)
        {
            this.lof = lof;
        }
        public Item(string name, double price)
        {
                this.Name = name;
                this.Price = price;
        }
    }
}
