using System;
using System.Xml.Serialization;
namespace HW_8
{
    public class Book
    {
        private string id;
        private string isbn;
        private string author;
        private string title;
        private string genre;
        private string publisher;
        private DateTime publish_date;
        private string description;
        private DateTime registration_date;

        [XmlAttribute("id")]
        public string ID { get { return id; } set { id = value; } }
        [XmlElement("isbn")]
        public string ISBN { get { return isbn; } set { isbn = value; } }
        [XmlElement("author")]
        public string Author { get { return author; } set { author = value; } }
        [XmlElement("title")]
        public string Title { get { return title; } set { title = value; } }
        [XmlElement("genre")]
        public string Genre { get { return genre; } set { genre = value; } }
        [XmlElement("publisher")]
        public string Publisher { get { return publisher; } set { publisher = value; } }
        [XmlElement("publish_date")]
        public DateTime PublishDate { get { return publish_date; } set { publish_date = value; } }
        [XmlElement("description")]
        public string Desccription { get { return description; } set { description = value; } }
        [XmlElement("registration_date")]
        public DateTime RegistrationDate { get { return registration_date; } set { registration_date = value; } }

        public Book()
        {
            this.ID = null;
            this.ISBN = null;
            this.Author = null;
            this.Title = null;
            this.Genre = null;
            this.Publisher = null;
            this.PublishDate = default(DateTime);
            this.Desccription = null;
            this.RegistrationDate = default(DateTime);
        }
        public Book(string id, string isbn, string author, string title, string genre, string publisher,
            DateTime publishDate, string description, DateTime registrationDate)
        {
            this.ID = id;
            this.ISBN = isbn;
            this.Author = author;
            this.Title = title;
            this.Genre = genre;
            this.Publisher = publisher;
            this.PublishDate = publishDate;
            this.Desccription = description;
            this.RegistrationDate = registrationDate;
        }
    }
}