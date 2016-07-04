using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Calculator;
namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isConfiguration;
            bool isCalculator;
            double a;
            double b;
            double sum;
            double subtraction;
            double multiply;
            double divide;

            Console.WriteLine("Choose one: Use configuration file (type 1) or take data from console (type 2)");
            string choiceConfig = Console.ReadLine();
            isConfiguration = setConfig(choiceConfig);
            if (isConfiguration)
            {
                a = Double.Parse(Data.firstNumber);
                b = Double.Parse(Data.secondNumber);
                Console.WriteLine($"Your numbers are {a} and {b}");
                string choice = ConfigurationManager.AppSettings["useCalculator"];
                isCalculator = setCalculator(choice);
            }
            else
            {
                Console.WriteLine("Enter first number");
                a = ReadDouble();
                Console.WriteLine("Enter second number");
                b = ReadDouble();
                Console.WriteLine("Choose one: Use own methods (type 1) or use Calculator library methods (type 2)");
                string choiceCalc = Console.ReadLine();
                isCalculator = setCalculator(choiceCalc);
            }
            if(!isCalculator)
            {
                Console.WriteLine("Now program will calculate all basic operations for two numbers using it's own methods.");
                sum = Sum(a, b);
                subtraction = Subtraction(a, b);
                multiply = Multiply(a, b);
                divide = Divide(a, b);
                Console.WriteLine($"Sum is {sum}, Subtraction is {subtraction}");
                Console.WriteLine($"Multiply is {multiply}, Divide is {divide}");
            }
            else
            {
                Console.WriteLine("Now program will calculate all basic operations for two numbers using library Calculator.");
                Calc c = new Calc();
                sum = c.Sum(a, b);
                subtraction = c.Subtraction(a, b);
                multiply = c.Multiply(a, b);
                divide = c.Divide(a, b);
                Console.WriteLine($"Sum is {sum}, Subtraction is {subtraction}");
                Console.WriteLine($"Multiply is {multiply}, Divide is {divide}");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static double Sum (double a, double b)
        {
            return a + b;
        }
        static double Subtraction(double a, double b)
        {
            return a - b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            return a / b;
        }
        static bool setCalculator(string choice)
        {
            if (choice.Equals("1"))
            {
                return false;
            }
            else if (choice.Equals("2"))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Oops, something went wrong. Maybe, you made incorrect input. Try again later.");
                Environment.Exit(-1);
                return false;
            }
        }
        static bool setConfig(string choice)
        {
            if (choice.Equals("1"))
            {
                return true;
            }
            else if (choice.Equals("2"))
            {
                return false;
            }
            else
            {
                Console.WriteLine("Oops, something went wrong. Maybe, you made incorrect input. Try again later.");
                Environment.Exit(-1);
                return false;
            }
        }
        static double ReadDouble()
        {
            double number;
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Please, enter valid number");
                }
                else
                {
                    return number;
                }
            }
        }
    }
}
