using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace HW_8
{
    class Serializing
    {
        public string PathToXML {get; set;}
        public string PathToNewXML { get; set; }
        public XmlSerializer XS { get; set; }
        public XmlSerializerNamespaces NS { get; set; }
        public XmlWriterSettings Settings { get; set; }
        public Catalog Catalog { get; set; }
        public Serializing(string path, string newPath)
        {
            this.Catalog = new Catalog();
            this.PathToXML = path;
            this.PathToNewXML = newPath;
            this.XS = new XmlSerializer(Catalog.GetType());
            this.NS = new XmlSerializerNamespaces();
            this.NS.Add("", "http://library.by/catalog");
            this.Settings = new XmlWriterSettings();
            this.Settings.Encoding = Encoding.UTF8;
            this.Settings.Indent = true;
        }

        public string Deserialize()
        {
            using (var fs = new FileStream(this.PathToXML, FileMode.Open))
            {
                this.Catalog = (Catalog)this.XS.Deserialize(fs);
            }
            return "Deserialization complete";
        }
        public string Serialize()
        {
            using (var fs = new FileStream(PathToNewXML, FileMode.Create))
            {
                using (var xw = XmlWriter.Create(fs, this.Settings))
                {
                    this.XS.Serialize(xw, this.Catalog, this.NS);
                }
            }
            return "Serialization complete";
        }
    }
}
