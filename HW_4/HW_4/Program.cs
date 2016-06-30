using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_4_3;
using System.Numerics;

namespace HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                SelfCountableClass scc = new SelfCountableClass();
                Console.WriteLine(scc.I);
            }

            Console.ReadKey();
            for (int i = 1; i < 50; i++)
            {
                SelfCountableClass scc = new SelfCountableClass();
                Console.WriteLine(scc.I);
            }
            Console.ReadKey();
        }
        public static double Fib(int index)
                {
                    double fib;
                    fib = (Math.Pow((1 + Math.Sqrt(5)) / 2, (double)index) - Math.Pow((1 - Math.Sqrt(5)) / 2, (double)index)) / Math.Sqrt(5);
                    return fib;
                }
        public static double FibRec(int index)
        {
            if (index == 1)
                return 1;
            if (index == 2)
                return 1;
            return FibRec(index - 2) + FibRec(index - 1);
        }
        static BigInteger ProdTree(int l, int r)
        {
            if (l > r)
                return 1;
            if (l == r)
                return l;
            if (r - l == 1)
                return (BigInteger)l * r;
            int m = (l + r) / 2;
            return ProdTree(l, m) * ProdTree(m + 1, r);
        }
        static BigInteger FactTree(int n)
        {
            if (n < 0)
                return 0;
            if (n == 0)
                return 1;
            if (n == 1 || n == 2)
                return n;
            return ProdTree(2, n);
        }
    }
}
