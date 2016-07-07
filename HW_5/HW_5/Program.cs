using System;
using System.IO;

namespace HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            string tempPath = $"{Data.path}_{DateTime.Now.ToString("dd-MM-yy_HH-mm-ss")}.txt";
            if (!File.Exists(tempPath))
            {
                var stream = File.Create(tempPath);
                stream.Close();
            }
            Checker checker = new Checker(tempPath);
            Console.WriteLine("Checking Dictionary");
            checker.CheckDictionary(n);
            Console.WriteLine("Checking Sorted Dictionary");
            checker.CheckSortedDictionary(n);
            Console.WriteLine("Checking Sorted Set");
            checker.CheckSortedSet(n);
            Console.WriteLine("Checking Queue");
            checker.CheckQueue(n);
            Console.WriteLine("Checking Stack");
            checker.CheckStack(n);
            Console.WriteLine("Checking Sorted Set");
            checker.CheckList(n);
            Console.WriteLine("Checking Linked List");
            checker.CheckLinkedList(n);
            Console.WriteLine("Checking complete. Press any key to exit.");
            Console.ReadLine();
        }
    }
}
