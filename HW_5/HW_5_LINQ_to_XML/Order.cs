using System;
using System.Xml.Linq;
namespace HW_5_LINQ_to_XML
{
    public class Order
    {
        static int i = 0;
        public XElement OrderElement;
        public string ID { get; set; }
        public DateTime OrderDate { get; set; }
        public double Total { get; set; }

        public Order()
        {
            this.ID = null;
            this.OrderDate = default(DateTime);
            this.Total = 0.0;
        }
        public Order(XElement element)
        {
            this.OrderElement = element;
            GetDataFromXElement();
        }
        public Order(string id, DateTime orderDate, double total)
        {
            this.ID = id;
            this.OrderDate = orderDate;
            this.Total = total;
        }

        public void GetDataFromXElement()
        {
            this.ID = OrderElement.Element("id").Value;
            i++;
            this.OrderDate = DateTime.Parse(OrderElement.Element("orderdate").Value);
            this.Total = Double.Parse(OrderElement.Element("total").Value);
        }
        public override string ToString()
        {
            return $"\t{this.ID}\r\n\t{this.OrderDate}\r\n\t{this.Total.ToString("0.00")}\r\n";
        }
    }
}
