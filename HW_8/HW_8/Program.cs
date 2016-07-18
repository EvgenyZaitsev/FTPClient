using System;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Xml;

namespace HW_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string PathToXML = Data.PathToFile + Data.FileName;
            string PathToNewXML = Data.PathToFile + "New_" + Data.FileName;
            Catalog catalog = new Catalog();
            catalog.Books.Add(new Book("1", "1", "1", "1", "1", "1", default(DateTime), "1", default(DateTime)));
            catalog.Books.Add(new Book("2", "2", "2", "2", "2", "2", default(DateTime), "2", default(DateTime)));
            XmlSerializer xs = new XmlSerializer(typeof(Catalog));
            Catalog c;
            using (FileStream fs = new FileStream(PathToXML, FileMode.Open))
            {
                c = (Catalog)xs.Deserialize(fs);
                Console.WriteLine("Объект десериализован");

            }
//            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
//            ns.Add("", "http://library.by/catalog");
            c.Books.ForEach(x => x.Desccription = x.Desccription.Replace("\n", "\r\n"));
            using (FileStream fs = new FileStream(PathToNewXML, FileMode.OpenOrCreate))
            {
                xs.Serialize(fs, c);
                Console.WriteLine("Объект сериализован");
            }
            Console.ReadKey();
        }
    }
}
