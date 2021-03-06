﻿using System;
using System.Collections;

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
//            host = "ftp://home.dimonius.ru";
            string rootHost = host;
            Client client = new Client(login, password);
            FTP ftp = new FTP(host, client);            
            Console.WriteLine("Type name of file or directory to download or open it.");
            Console.WriteLine("Type /exit to exit program.");
            Console.WriteLine("Type /root to go to root folder.");
            Console.WriteLine();
            ArrayList listOfFiles = ftp.GetListOfFiles();
            foreach (string s in listOfFiles)
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
                    if (ftp.Download(choise))
                    {
                        Console.WriteLine("File succesfully downloaded.");
                    }
                        else
                        {
                        host = host + "/" + choise;
                        ftp = new FTP(host, client);
                        }
                    }
                listOfFiles = ftp.GetListOfFiles();
                foreach (string s in listOfFiles)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
            }
        }
    }
}
