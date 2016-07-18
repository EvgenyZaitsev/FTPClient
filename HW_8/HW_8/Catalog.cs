using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace HW_8
{
    [XmlRootAttribute("catalog", Namespace = "http://library.by/catalog", IsNullable = false)]
    public class Catalog
    {
        private List<Book> books;
        private DateTime date;
        [XmlAttribute("date")]
        public DateTime Date { get { return date; } set { date = value; } }
        [XmlElement("book")]
        public List<Book> Books { get { return books; } set { books = value; } }
        public Catalog()
        {
            this.Books = new List<Book>();
            this.Date = default(DateTime);
        }
        public Catalog(List<Book> books, DateTime date)
        {
            this.Books.AddRange(books);
            this.Date = date;
        }
    }
}
