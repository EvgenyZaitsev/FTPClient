using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    public class Current_Element
    {
        public string Element { get; set; }
        public string TypeOfElement { get; set; }

        public Current_Element(string element, string type)
        {
            this.Element = element;
            this.TypeOfElement = type;
        }
        public void Print()
        {
            Console.WriteLine(TypeOfElement + " " + Element);
        }
    }
}
