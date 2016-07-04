using System;
using System.Collections.Generic;
using System.Numerics;
namespace HW_4_2
{
    public class FibAndFact
    {
        public int Index { get; set; }

        public FibAndFact(int index)
        {
            this.Index = index;
        }
        public double Fib()
        {
            double fib;
            double d1 = (1 + Math.Sqrt(5)) / 2;
            double d2 = (1 - Math.Sqrt(5)) / 2;
            fib = ((Math.Pow(d1, this.Index)) - Math.Pow(d2, this.Index)) / Math.Sqrt(5);
            return fib;
        }
        public BigInteger FactTree()
         {
            if (this.Index < 0)
                 return 0;
            if (this.Index == 0)
                 return 1;
            if (this.Index == 1 || this.Index == 2)
                return this.Index;
            return ProdTree(2, this.Index);
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
    }
}
