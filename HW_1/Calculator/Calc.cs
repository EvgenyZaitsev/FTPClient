using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public double Multiply(int a, int b)
        {
            return (double)a * (double)b;
        }
        public double Divide(int a, int b)
        {
            return (double)a / (double)b;
        }
        

    }
}
