using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            double sum = c.Sum(1, 2);
            double mult = c.Multiply(5, 5);
            double sub = c.Subtract(13, 666);
            double div = c.Divide(6, 8);
        }
    }
}
