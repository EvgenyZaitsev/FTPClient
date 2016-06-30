using System;
using System.IO;

namespace HW_3_1
{
    class Folder
    {
        private string name;
        private string path;
        private string fileName;

        public Folder(string name, string path)
        {
            this.name = name;
            this.path = path;
        }
        public bool CreateFolder()
        {
            if (Directory.Exists(path + name))
            {
                Console.WriteLine("This folder is already exist.");
                return false;
            }
            else
            {
                Directory.CreateDirectory(path + name);
                Console.WriteLine("Folder successfully created.");
                return true;
            }
        }
        public bool CreateFile(string path)
        {
            string fileData;
            if (File.Exists(this.path + name + "\\" + FileName + ".txt"))
            {
                Console.WriteLine("File already exists. Data will be rewrited.");
            }
            else
            {
                var fileStream = File.Create(this.path + name + "\\" + FileName + ".txt");
                fileStream.Close();
            }

            if (File.Exists(path))
            {
                fileData = ReadTwentyOrLessLines(path);
                using (StreamWriter sw = new StreamWriter(this.path + name + "\\" + FileName + ".txt"))
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

        public string Name
        {
            set { name = value; }
            get { return name; }

        }
        public string Path
        {
            set { path = value; }
            get { return path; }

        }
        public string FileName
        {
            set { fileName = value; }
            get { return fileName; }

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
                        fileData += fileLine;
                        fileData += "\r\n";
                    }
                   
                }
            return fileData;
        }
    }
}
