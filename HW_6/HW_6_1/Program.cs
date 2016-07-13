using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_6_2;
namespace HW_6_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            File file = new File(GetPath());
            WorkingWithFile(file);
            Console.ReadKey();
        }
        public static string GetPath()
        {
            Console.WriteLine("Enter path to file.");
            return Console.ReadLine();
        }
        public static void WorkingWithFile(File file)
        {
            try
            {
                file.GetFileLines();
                try
                {
                    file.GetFileInfo();
                }
                catch (Exception e)
                {
                    Logger log = new Logger(Data.LogPath);
                    log.Log(e.StackTrace);
                    Console.WriteLine(e.Message);
                }
                try
                {
                    file.PrintToConsole();
                }
                catch (IOException e)
                {
                    Logger log = new Logger(Data.LogPath);
                    log.Log(e.StackTrace);
                    Console.WriteLine(e.Message);
                }
            }
            catch (Exception e)
            {
                Logger log = new Logger(Data.LogPath);
                log.Log(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
