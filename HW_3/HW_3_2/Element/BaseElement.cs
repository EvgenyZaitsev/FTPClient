using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HW_3_2.Element
{
    public class BaseElement : ILoggable
    {
        string Text;
       public void Log()
        {
            Log(); // :)
        }
        public void Click()
        {
            //click to a random place
        }
        public void setText(string text)
        {
            this.Text = text;
        }
    }
}
