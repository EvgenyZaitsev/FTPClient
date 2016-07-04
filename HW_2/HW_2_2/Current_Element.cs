using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Current_Element
    {
        string Element { get; set; }
        string TypeOfElement { get; set; }

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
