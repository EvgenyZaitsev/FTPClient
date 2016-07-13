using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
namespace HW_5_LINQ_to_XML
{
    public class Customer
    {
        public XElement CustomerElement { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Region { get; set; }
        public List<Order> Orders { get; set; }

        public Customer()
        {
            this.ID = null;
            this.Name = null;
            this.Address = null;
            this.City = null;
            this.PostalCode = null;
            this.Country = null;
            this.Phone = null;
            this.Fax = null;
            this.Region = null;
            this.Orders = null;
        }
        public Customer(XElement element)
        {
            this.CustomerElement = element;
            this.Orders = new List<Order>();
            GetDataFromXElement();
        }
        public Customer(string id, string name, string address, string city, string postalCode, string country, string phone, string fax, string region, List<Order> orders)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.PostalCode = postalCode;
            this.Country = country;
            this.Phone = phone;
            this.Fax = fax;
            this.Region = region;
            this.Orders = orders;
        }

        public void GetDataFromXElement()
        {
            this.ID = CustomerElement.Element("id")?.Value;
            this.Name = CustomerElement.Element("name")?.Value;
            this.Address = CustomerElement.Element("address")?.Value;
            this.City = CustomerElement.Element("city")?.Value;
            this.PostalCode = CustomerElement.Element("postalcode")?.Value;
            this.Country = CustomerElement.Element("country")?.Value;
            this.Phone = CustomerElement.Element("phone")?.Value;
            this.Fax = CustomerElement.Element("fax")?.Value;
            this.Region = CustomerElement.Element("region")?.Value;
            var orders = CustomerElement.Element("orders").Elements("order").ToList();
            foreach (XElement xe in orders)
                Orders.Add(new Order(xe));

        }
        public double GetSumOrders()
        {
            return Orders
                .Sum(order => order.Total);
        }
        public double GetMaxOrder()
        {
            if (Orders.Count == 0)
                return 0.0;
            return Orders
                .Max(order => order.Total);
        }
        public override string ToString()
        {
            String s = $"{this.ID}\r\n{this.Name}\r\n{this.Address}\r\n{this.City}\r\n{this.PostalCode}\r\n{this.Country}\r\n{this.Phone}\r\n{this.Fax}\n\r";
            foreach (Order o in Orders)
                s += $"{o}\r\n";
            return s;
        }
    }
}
