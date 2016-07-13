using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_2
{
    public class ParseIntHard
    {
        public string StringNumber { get; set; }
        public bool IsNegative { get; set; }
        public ParseIntHard(string s)
        {
            this.StringNumber = s;
        }
        public void CheckNegative()
        {
            if (this.StringNumber[0] == '-')
            {
                this.StringNumber = this.StringNumber.Substring(1);
                IsNegative = true;
            }
            if (this.StringNumber[0] == '+')
            {
                this.StringNumber = this.StringNumber.Substring(1);
                IsNegative = false;
            }
            IsNegative = false;
        }
        public int TryParse(out int number)
        {
            number = default(int);
            CheckNegative();
            if (this.StringNumber.Length == 0)
                return 0;
            foreach (char c in this.StringNumber)
            {
                if (c > '9' || c < '0')
                    return 0;
            }
            if (this.StringNumber.Length >= 9 && 
                (this.StringNumber.CompareTo(Int32.MaxValue.ToString()) == 1 ||
                this.StringNumber.CompareTo(Int32.MinValue.ToString()) == -1))
                return -1;
            while (this.StringNumber.Length > 0)
            {
                number += (this.StringNumber[0] - '0') * (int)Math.Pow(10, this.StringNumber.Length - 1);
                this.StringNumber = this.StringNumber.Substring(1);
            }
            if (IsNegative)
                return -number;
            return number;
        }
    }
}
