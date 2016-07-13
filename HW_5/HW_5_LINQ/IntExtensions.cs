using System;
using System.Numerics;
using System.Security.Cryptography;
namespace HW_5_LINQ
{
    public static class BigIntegerExtensions
    {
        public static bool isPrime(this BigInteger number)
        {
            int iterations = 100;
            if (number == 2 || number == 3)
                return true;
            if (number < 2 || number % 2 == 0)
                return false;

            BigInteger d = number - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[number.ToByteArray().LongLength];
            BigInteger a;
            for (int i = 0; i < iterations; i++)
            {
                do
                {
                    rng.GetBytes(bytes);
                    a = new BigInteger(bytes);
                } while (a < 2 || a >= number - 2);
                BigInteger x = BigInteger.ModPow(a, d, number);
                if (x == 1 || x == number - 1)
                    continue;
                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, number);
                    if (x == 1)
                        return false;
                    if (x == number - 1)
                        break;
                }
                if (x != number - 1)
                    return false;
            }
            return true;
        }
        public static bool IsContainsTwo(this BigInteger number)
        {
            if (number.ToString().Contains("2"))
                return true;
            return false;

        }
        public static int FiguresSum(this BigInteger number)
        {
            int sum = 0;
            char[] newNumber = number.ToString().ToCharArray();
            foreach (char figure in newNumber)
            {
                sum += figure - '0';
            }
            return sum;
        }
        public static int GetSecondFigure(this BigInteger number)
        {
            if (number < 10)
                return -1;
            return number.ToString()[1];
        } 
        public static int GetSquareOfFiguresSum(this BigInteger number)
        {
            int sum = 0;
            char[] newNumber = number.ToString().ToCharArray();
            foreach (char figure in newNumber)
            {
                sum += (int)Math.Pow(figure - '0', 2);
            }
            return sum;
        }
        public static int GetZeroesAmount(this BigInteger number)
        {
            int zeroes = 0;
            char[] newNumber = number.ToString().ToCharArray();
            foreach (char figure in newNumber)
            {
                if (figure == '0')
                    zeroes++;
            }
            return zeroes;
        }
    }
}
