using System;
using System.Collections.Generic;
using System.Numerics;
namespace HW_4_2
{
    public class FibAndFact
    {
        private int index;

        public FibAndFact(int index)
        {
            this.index = index;
        }
        public double Fib()
        {
            double fib;
            fib = ((Math.Pow((1 + Math.Sqrt(5)) / 2, (double)index)) - Math.Pow((1 - Math.Sqrt(5)) / 2, (double)index)) / Math.Sqrt(5);
            return fib;
        }
        public BigInteger FactTree()
        {
            if (index < 0)
                return 0;
            if (index == 0)
                return 1;
            if (index == 1 || index == 2)
                return index;
            return ProdTree(2, index);
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
