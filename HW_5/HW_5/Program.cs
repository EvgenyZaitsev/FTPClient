using System;
using System.IO;

namespace HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempPath = $"{Data.path}_{DateTime.Now.ToString("dd-MM-yy_HH-mm-ss")}.txt";
            if (!File.Exists(tempPath))
            {
                var stream = File.Create(tempPath);
                stream.Close();
            }
            Checker checker = new Checker(tempPath);
            Console.WriteLine("Checking Dictionary");
            checker.CheckDictionary();
            Console.WriteLine("Checking Sorted Dictionary");
            checker.CheckSortedDictionary();
            Console.WriteLine("Checking Sorted Set");
            checker.CheckSortedSet();
            Console.WriteLine("Checking Queue");
            checker.CheckQueue();
            Console.WriteLine("Checking Stack");
            checker.CheckStack();
            Console.WriteLine("Checking Sorted Set");
            checker.CheckList();
            Console.WriteLine("Checking Linked List");
            checker.CheckLinkedList();
            Console.WriteLine("Checking complete. Press any key to exit.");
            Console.ReadLine();
        }
    }
}
