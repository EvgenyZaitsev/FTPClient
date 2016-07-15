using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_2
{
    public class ParseIntEasy
    {
        public string StringNumber { get; set;}
        private const double intMaxValue = (double)Int32.MaxValue;
        private const double intMinValue = (double)Int32.MinValue;
        public ParseIntEasy(string s)
        {
            this.StringNumber = s;
        }
        public int TryParse(out int number)
        {
            
            number = default(int);
            double d;
            if (this.StringNumber == null)
                return 0;
            if (!double.TryParse(this.StringNumber.Replace(',','.'), out d))
                return 0;
            if (d > intMaxValue || d < intMinValue)
                return -1;
            number = (int)d;
            if ((double)number - d != 0)
                return -1;
            return 1;
        }
        public string Explanation()
        {
            int i;
            if (TryParse(out i) == -1)
                return "String is a number, but it is out of integer bounds.";
            if (TryParse(out i) == 0)
                return "String can't be converted to number.";
            return $"String can be converterd to integer. So, it is {i}";
        }
    }
}
