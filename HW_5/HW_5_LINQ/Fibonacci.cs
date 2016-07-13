using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace HW_5_LINQ
{
    public class Fibonacci
    {
        public List<BigInteger> Fib { get; set; }
        public int Amount { get; set; }
        public Fibonacci()
        {
            this.Amount = 0;
            this.Fib = null;
        }
        public Fibonacci(int amount)
        {
            this.Amount = amount;
            this.Fib = new List<BigInteger>();
            CountFibonacci();
        }
        public void CountFibonacci()
        {
            for (int i = 1; i < this.Amount + 1; i++)
            {
                BigInteger a = BigInteger.Zero;
                BigInteger b = BigInteger.One;
                for (int j = 31; j >= 0; j--)
                {
                    BigInteger d = a * (b * 2 - a);
                    BigInteger e = a * a + b * b;
                    a = d;
                    b = e;
                    if (((i >> j) & 1) != 0)
                    {
                        BigInteger c = a + b;
                        a = b;
                        b = c;
                    }
                }
                Fib.Add(a);
            }
        }
        public override string ToString()
        {
            string s = "";
            for(int i = 0; i < this.Amount; i++)
                s += $"{i + 1}. {this.Fib[i]}\r\n";
            return s;
        }

        public int CountPrime()
        {
            return Fib.Where(x => x.isPrime()).ToList().Count;
        }
        public int CountDivideByItFiguresNumbers()
        {
            return Fib.Where(x => x.FiguresSum() != 0 && x % x.FiguresSum() == 0).ToList().Count;
        }
        public int CountDivideByFiveNumbers()
        {
            return Fib.Where(x => x % 5 == 0).ToList().Count;
        }
        public List<BigInteger> NumbersWithTwoSqrt()
        {
            List<BigInteger> sqrts = new List<BigInteger>();
            foreach (BigInteger element in Fib.Where(x => x.IsContainsTwo()).ToList())
                    sqrts.Add((BigInteger)Math.Exp(BigInteger.Log(element) / 2));
            return sqrts;
        }
        public List<BigInteger> SortBySecondFigure()
        {
            List<BigInteger> SortedList = Fib.OrderByDescending(number => number.GetSecondFigure()).ToList();
            return SortedList;
        }
        public List<string> GetLastTwoFiguresForNumbersWithGoodNeighbours()
        {
            List<string> lastTwoFiguresForNumbersWithGoodNeighbours = new List<string>();
            for(int i = 0; i < Fib.Count; i++)
            {
                if (Fib[i]% 3 == 0)
                {
                    List<BigInteger> neighbours = new List<BigInteger>();
                    int before = (i - 5) < 0 ? 0 : (i - 5);
                    int after = (Fib.Count - i) < 5 ? Fib.Count : (i + 5);
                    for (int j = before; j < after; j++)
                    {
                        if (Fib[j] % 5 == 0 && i != j)
                        {
                            BigInteger temp = Fib[i];
                            if (temp < 100)
                                lastTwoFiguresForNumbersWithGoodNeighbours.Add(temp.ToString());
                            else
                            {
                                string s = temp.ToString();
                                lastTwoFiguresForNumbersWithGoodNeighbours.Add(s.Substring(s.Length - 2));
                            }
                            break;
                        }
                    }
                }
            }
            return lastTwoFiguresForNumbersWithGoodNeighbours;
        }
        public BigInteger GetNumberWithMaxSumOfFiguresSquares()
        {
            BigInteger max = 0;
            int maxSum = 0;
            foreach (BigInteger element in Fib.Where(x => x.GetSquareOfFiguresSum() >= maxSum))
            {
                maxSum = element.GetSquareOfFiguresSum();
                max = element;
            }
            return max;
        }
        public double GetAverageZeroesNumber()
        {
            int count = 0;
            foreach (BigInteger element in Fib)
                count += element.GetZeroesAmount();
            return (double)count / (double)Fib.Count;
        }
    }
}
