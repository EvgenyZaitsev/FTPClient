using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_2.Element
{
    public class TextArea : BaseElement
    {
        string text;
        public void SetText(string text)
        {
            this.text = text;
        }
    }
}
