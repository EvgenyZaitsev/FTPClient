using System;

namespace HW_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string PathToXML = Data.PathToFile + Data.FileName;
            string PathToNewXML = Data.PathToFile + "New_" + Data.FileName;
            string ss = Environment.NewLine;
            Serializing s = new Serializing(PathToXML, PathToNewXML);
            Console.WriteLine(s.Deserialize());
            Console.WriteLine(s.Serialize());
            Console.ReadKey();
        }
    }
}
