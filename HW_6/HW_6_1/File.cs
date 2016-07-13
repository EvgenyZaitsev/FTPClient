using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_6_1
{
    public class File
    {
        public string FilePath { get; set; }
        public List<string> ListOfLines { get; set; }
        public List<string> FileInfo { get; set; }
        public List<int> EmptyLines { get; set; }
        public File(string path)
        {
            this.FilePath = path;
        }
        public void GetFileLines()
        {
            if (!System.IO.File.Exists(this.FilePath))
                throw new FileNotFoundException("Wrong path to File! Enter correct path, please.");
            if ((ListOfLines = System.IO.File.ReadAllLines(this.FilePath).ToList()) == null)
                throw new FileLoadException("Can't read data from file. Plase, check it for correction.");
            if (ListOfLines.Count == 0)
                throw new IOException("No data in file. Please, fill it before.");
        }
        public void GetFileInfo()
        {
            FileInfo = new List<string>();
            EmptyLines = new List<int>();
            for (int i = 0; i < ListOfLines.Count; i++)
            {
                if (ListOfLines[i].Length == 0)
                {
                    FileInfo.Add("Empty line");
                    EmptyLines.Add(i);
                }
                else
                    FileInfo.Add(ListOfLines[i].Substring(0, 1));
            }
        }
        public void PrintToConsole()
        {
            for (int i = 0; i < FileInfo.Count; i++)
                Console.WriteLine($"{i + 1}. {FileInfo[i]}");
            if (EmptyLines.Count > 0)
            {
                string error = "There were some errors due to empty lines ";
                foreach (int number in EmptyLines)
                    error += (number + 1).ToString() + " ";
                error += "Please, do something with it.";
                throw new IOException(error);
            }
}
    }
}
