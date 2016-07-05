using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some data (numbers, strings).");
            Console.WriteLine("If you don't want to enter data anymore, type /e");
            DoSomeMagic();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void DoSomeMagic()
        {
            WorkWithText text = new WorkWithText();
            text.Read();
            text.SetType();
            text.PrintInteger();
            text.PrintDouble();
            text.PrintString();
        }
    }
}
