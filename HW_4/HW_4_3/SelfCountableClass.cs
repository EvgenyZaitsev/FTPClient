using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_3
{
    public class SelfCountableClass
    {
        static int i = 0;
        public SelfCountableClass()
        {
            i++;
        }
        public int I
        {
            set { i = value; }
            get { return i; }
        }
    }
}
