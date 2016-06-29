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
            Console.WriteLine("This program will take data from file with path written at resoure file and do some things with it:");
            Console.WriteLine("     All big letters will become small.\n     Every sentence will start at new line.\n     DateStamp before sentences.");
            string path = DataRes.Path;
            DoSomeMagic(path);
            Console.WriteLine("Check your file. Press any key to exit.");
            Console.ReadKey();
        }
        static void DoSomeMagic(string path)
        {
            Text text = new Text();
            text.Initiate(path);
            text.Split();
            text.ToLowCase();
            text.AddLine();
            text.AddTimeStamp();
            text.Print(path);
        }
    }
}
