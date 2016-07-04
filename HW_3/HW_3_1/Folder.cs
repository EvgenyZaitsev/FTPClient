using System;
using System.IO;

namespace HW_3_1
{
    class Folder
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }

        public Folder(string name, string path)
        {
            this.Name = name;
            this.Path = path;
        }
        public bool CreateFolder()
        {
            if (Directory.Exists(this.Path + this.Name))
            {
                Console.WriteLine("This folder is already exist.");
                return false;
            }
            else
            {
                Directory.CreateDirectory(this.Path + this.Name);
                Console.WriteLine("Folder successfully created.");
                return true;
            }
        }
        public bool CreateFile(string path)
        {
            string fileData;
            if (File.Exists(this.Path + this.Name + "\\" + FileName + ".txt"))
            {
                Console.WriteLine("File already exists. Data will be rewrited.");
            }
            else
            {
                var fileStream = File.Create(this.Path + this.Name + "\\" + FileName + ".txt");
                fileStream.Close();
            }

            if (File.Exists(path))
            {
                fileData = ReadTwentyOrLessLines(path);
                using (StreamWriter sw = new StreamWriter(this.Path + this.Name + "\\" + FileName + ".txt"))
                {
                    sw.Write(fileData);
                }
                Console.WriteLine("Data successfully wrote to the file.");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong path to the file!");
                return false;
            }
        }

        static public string ReadTwentyOrLessLines(string path)
        {
            string fileData = "";
            string fileLine;
            int i = 0;
            
                using (StreamReader sr = new StreamReader(path))
                {
                    while (++i < 20 && (fileLine = sr.ReadLine()) != null)
                    {
                        fileData += fileLine + "\r\n";
                    }
                   
                }
            return fileData;
        }
    }
}
