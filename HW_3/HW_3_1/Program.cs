using System;

namespace HW_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of the folder, that will be created.");
            string folderName;
            folderName = Console.ReadLine();
            string path;
            path = ResData.pathDir;
            Folder directory = new Folder(folderName, path);
            directory.CreateFolder();
            Console.WriteLine("Enter name of the file(without extention), that will be created in this folder.");
            string fileName;
            fileName = Console.ReadLine();
            string filePath;
            filePath = ResData.pathFile;
            directory.FileName = fileName;
            if (directory.CreateFile(filePath))
                Console.WriteLine("Data successfully wrote. Press any key to exit.");
            else
                Console.WriteLine("Some problems with file. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
