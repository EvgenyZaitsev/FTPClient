using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = "";
            string login = "";
            string password = "";

            switch (args.Length)
            {
                case 0:
                    Console.WriteLine("please, enter host and login with password (optionally).");
                    return;
                case 1:
                    host = args[0];
                    Console.WriteLine("Trying to connect to " + host + "without login and password.");
                    break;
                case 2:
                    host = args[0];
                    login = args[1];
                    Console.WriteLine("Trying to connect to " + host + "with login " + login + " and without password.");
                    break;
                default:
                    host = args[0];
                    login = args[1];
                    password = args[2];
                    Console.WriteLine("Trying to connect to " + host + "with login " + login + " and password " + password + ".");
                    break;
            }
//            host = "ftp://ftp.mccme.ru";
            string rootHost = host;
            Client client = new Client(login, password);
            FTP ftp = new FTP(host, client);            
            Console.WriteLine("Type name of file or directory to download or open it.");
            Console.WriteLine("Type /exit to exit program.");
            Console.WriteLine("Type /root to go to root folder.");
            Console.WriteLine();
            ArrayList al = ftp.getList();
            foreach (string s in al)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();           
            while (true)
            {
                string choise = Console.ReadLine();
                if (choise == "/exit")
                {
                    return;
                }
                else
                    if (choise == "/root")
                    {
                        host = rootHost;
                        ftp = new FTP(host, client);
                    }
                else {
                    if (ftp.download(choise))
                    {
                        Console.WriteLine("File succesfully downloaded.");
                    }
                        else
                        {
                        host = host + "/" + choise;
                        ftp = new FTP(host, client);
                        }
                    }
                al = ftp.getList();
                foreach (string s in al)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
            }
        }
    }
}
