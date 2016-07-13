using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_LINQ_to_XML
{
    public class OrderWithCustomer
    {
        public Order Order { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Region { get; set; }

        public OrderWithCustomer(Customer c, Order o)
        {
            this.ID = c.ID;
            this.Name = c.Name;
            this.Address = c.Address;
            this.City = c.City;
            this.PostalCode = c.PostalCode;
            this.Country = c.Country;
            this.Phone = c.Phone;
            this.Fax = c.Fax;
            this.Region = c.Region;
            this.Order = o;
        }

        public override string ToString()
        {
//            String s = $"{this.ID}\r\n{this.Name}\r\n";//{this.Address}\r\n{this.City}\r\n{this.PostalCode}\r\n{this.Country}\r\n{this.Phone}\r\n{this.Fax}\n\r{this.Order}\r\n";
            return $"{ this.Name}\r\n{this.Order}\r\n";
        }
    }
}
