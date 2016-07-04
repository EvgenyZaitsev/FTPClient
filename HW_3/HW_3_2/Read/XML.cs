using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_3_2.Read
{
    class XML
    {
        string Path { get; set; }
        List<string> Read()
        {
            List<string> Data = new List<string>();
            for (int i = 0; i < 10; i++)
                Data.Add(GetDataFromNothing());
            return Data;
        }
        public string GetDataFromNothing()
        {
            char[] str = new char[100];
            for (int i = 0; i < 100; i++)
                str[i] = (char)new Random().Next(30, 130);
            return new string(str);
        }
        public void Print()
        {
            File.AppendAllLines(Path, Read());
        }
    }
}
