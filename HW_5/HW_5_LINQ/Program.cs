using System;
using System.Collections.Generic;
using System.Numerics;
namespace HW_5_LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            DoSomeStreetMagic();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        public static void DoSomeStreetMagic()
        {
            Fibonacci fib = new Fibonacci(200);
            Console.WriteLine(fib.ToString());

            Console.WriteLine($"This sequence has {fib.CountPrime()} prime numbers.");
            Console.ReadKey();

            Console.WriteLine($"This sequence has {fib.CountDivideByItFiguresNumbers()} numbers that can be divided by sum of it's figures.");
            Console.ReadKey();

            Console.WriteLine($"This sequence has {fib.CountDivideByFiveNumbers()} numbers that can be divided by five.");
            Console.ReadKey();

            Console.WriteLine($"This secuence has next square roots of elements that can be divided by two.");
            List<BigInteger> sqrts = fib.NumbersWithTwoSqrt();
            for (int i = 0; i < sqrts.Count; i++)
                Console.WriteLine($"{i + 1}. { sqrts[i]}");
            Console.ReadKey();

            Console.WriteLine("Sorted by second figure sequence is");
            List<BigInteger> sortedList = fib.SortBySecondFigure();
            for (int i = 0; i < sortedList.Count; i++)
                Console.WriteLine($"{i + 1}. { sortedList[i]}");
            Console.ReadKey();

            Console.WriteLine("Last two figures for numbers that can be divided by three and with neighbours\r\n" +
              "(five  or less elements to both sides) that can be divided by five in sequence are");
            List<string> lastTwoFiguresForNumbersWithGoodNeighbours = fib.GetLastTwoFiguresForNumbersWithGoodNeighbours();
            for (int i = 0; i < lastTwoFiguresForNumbersWithGoodNeighbours.Count; i++)
                Console.WriteLine($"{i + 1}. { lastTwoFiguresForNumbersWithGoodNeighbours[i]}");
            Console.ReadKey();

            Console.WriteLine($"Number with max sum of squares of it's figures in this sequence is {fib.GetNumberWithMaxSumOfFiguresSquares()}.");
            Console.ReadKey();

            Console.WriteLine($"Average zero amount in this sequence is {fib.GetAverageZeroesNumber().ToString("0.00")}");
        }
    }
}
