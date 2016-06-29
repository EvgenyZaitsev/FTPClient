using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Current_Element
    {
        string Element;
        string TypeOfElement;
        public Current_Element(string element, string type)
        {
            this.Element = element;
            this.TypeOfElement = type;
        }
        public void Print()
        {
            Console.WriteLine(TypeOfElement + " " + Element);
        }
        public string GetElement()
        {
            return Element;
        }
        public void SetElement(string Element)
        {
            this.Element = Element;
        }
        public string GetTypeOfElement()
        {
            return TypeOfElement;
        }
        public void SetType(string Type)
        {
            this.TypeOfElement = Type;
        }
    }
}
