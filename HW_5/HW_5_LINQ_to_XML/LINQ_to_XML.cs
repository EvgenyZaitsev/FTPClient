using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace HW_5_LINQ_to_XML
{
    class LINQ_to_XML
    {
        public string FilePath { get; set; }
        public XDocument Doc { get; set; }
        public XElement RootElement { get; set; }
        public LINQ_to_XML()
        {
            this.FilePath = Data.Path;
            this.Doc = XDocument.Load(this.FilePath);
            this.RootElement = Doc.Root;
        }
    }
}
