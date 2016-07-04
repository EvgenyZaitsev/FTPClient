using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_2.Element
{
    public class Button : BaseElement
    {
        private string text;
        public void setText(string text)
        {
            this.text = text;
        }
        public void Click()
        {
            //click this button
        }
        public void UpdatePage()
        {
            //Refresh
        }
        public override string ToString()
        {
            return $"Text of element is {text}";
        }
    }
}
