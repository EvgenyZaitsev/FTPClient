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
                this.IsNegative = true;
            }
            else if (this.StringNumber[0] == '+')
            {
                this.StringNumber = this.StringNumber.Substring(1);
                this.IsNegative = false;
            }
            else
                this.IsNegative = false;
        }
        public int TryParse(out int number)
        {

            number = default(int);
            if (this.StringNumber == null)
                return 0;
            if (this.StringNumber.Length == 0)
                return 0;
            CheckNegative();
            foreach (char c in this.StringNumber)
            {
                if ((c > '9' || c < '0') && (c !='.' || c!= ','))
                    return 0;
            }
            if (IsNegative)
            {
                if (this.StringNumber.Length >= 10 &&
                    ("-" + this.StringNumber).CompareTo(Int32.MinValue.ToString()) == 1)
                    return -1;
            }
            else
            {
                if (this.StringNumber.Length >= 10 &&
                    this.StringNumber.CompareTo(Int32.MaxValue.ToString()) == 1)
                    return -1;
            }
            if (this.StringNumber.Replace(',', '.').Contains("."))
                return -1;
            if (IsNegative)
                while (this.StringNumber.Length > 0)
                {
                    number -= (this.StringNumber[0] - '0') * (int)Math.Pow(10, this.StringNumber.Length - 1);
                    this.StringNumber = this.StringNumber.Substring(1);
                }
            else
                while (this.StringNumber.Length > 0)
                {
                    number += (this.StringNumber[0] - '0') * (int)Math.Pow(10, this.StringNumber.Length - 1);
                    this.StringNumber = this.StringNumber.Substring(1);
                }
            return 1;
        }
    }
}
