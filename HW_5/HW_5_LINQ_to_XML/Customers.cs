using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
namespace HW_5_LINQ_to_XML
{
    public class Customers
    {
        public List<Customer> ListOfCustomers { get; set; }
        public Customers()
        {
            this.ListOfCustomers = new List<Customer>();
        }
        public Customers(List<Customer> list)
        {
            this.ListOfCustomers = list;
        }

        public void ReadDataFromXML()
        {
            LINQ_to_XML LtXML = new LINQ_to_XML();
            foreach (XElement element in LtXML.RootElement.Elements())
            {
                Customer customer = new Customer(element);
                ListOfCustomers.Add(customer);
            }
        }

        public List<Customer> CustomersWithMoreThanXOrderSums(double sum)
        {
            return ListOfCustomers
                .Where(customer => customer.GetSumOrders() > sum)
                .ToList();
        }

        public List<Customer> CustomersWithMoreThanXOrder(double sum)
        {
            return ListOfCustomers
                .Where(customer => customer.GetMaxOrder() > sum)
                .ToList();
        }

        public List<IGrouping<string, Customer>> GroupCustomersByContry()
        {
            return ListOfCustomers.GroupBy(element => element.Country).ToList();
        }

        public Dictionary<string, DateTime?> ListOfFirstOrder()
        {

            return ListOfCustomers.ToDictionary(x => x.Name, c => c.Orders.Min(m => m?.OrderDate));
             
        }

        public Dictionary<string, DateTime?> SortedListOfFirstOrder()
        {
            var SortedList = ListOfCustomers.
                ToDictionary(x => x, c => c.Orders.Min(m => m?.OrderDate));
            return SortedList
                .OrderBy(d => d.Value)
                .ThenBy(x => x.Key.GetSumOrders())
                .ThenBy(x => x.Key.Name)
                .ToDictionary(d => d.Key.Name, c=> c.Value);

        }

        public List<Customer> CustomersWithLettersInPostalCodeNoRegionNoOperatorCode()
        {
            int t;
            return ListOfCustomers
                .Where(element => Int32.TryParse(element.PostalCode, out t) == false)
                .ToList()
                .Union(ListOfCustomers
                .Where(element => element.Region == null))
                .ToList()
                .Union(ListOfCustomers
                .Where(element => element.Phone.Trim()[0] != '('))
                .ToList()
                .Distinct()
                .ToList();
        }
        
        public List <CityWithEfficiency> CityWithAverageSumAndAverageIntencity()
        {
            List<CityWithEfficiency> cities = new List<CityWithEfficiency>();
            List<string> ListOfCities = new List<string>();
            foreach (Customer customer in ListOfCustomers)
                if (!ListOfCities.Contains(customer.City))
                    ListOfCities.Add(customer.City);
            foreach (string city in ListOfCities)
            {
                double AverageSum = ListOfCustomers
                    .Where(element => element.City == city)
                    .ToList()
                    .Average(element => element.GetSumOrders());
                double AverageIntencity = ListOfCustomers
                    .Where(element => element.City == city)
                    .ToList()
                    .Average(element => element.Orders.Count);
                cities.Add(new CityWithEfficiency(city, AverageSum, AverageIntencity));
            }
            return cities;
        }

        public List<IGrouping<int, OrderWithCustomer>> StatisticsByYear()
        {
            List<OrderWithCustomer> ordersWithCustomer = new List<OrderWithCustomer>();
            foreach (Customer customer in ListOfCustomers)
                foreach (Order order in customer.Orders)
                    ordersWithCustomer.Add(new OrderWithCustomer(customer, order));
            return ordersWithCustomer
                .GroupBy(element => element.Order.OrderDate.Year)
                .ToList();
        }
        public List<IGrouping<int, OrderWithCustomer>> StatisticsByMonth()
        {
            List<OrderWithCustomer> ordersWithCustomer = new List<OrderWithCustomer>();
            foreach (Customer customer in ListOfCustomers)
                foreach (Order order in customer.Orders)
                    ordersWithCustomer.Add(new OrderWithCustomer(customer, order));
            return ordersWithCustomer
                .GroupBy(element => element.Order.OrderDate.Month)
                .ToList();
        }
        public List<IGrouping<string, OrderWithCustomer>> StatisticsByYearAndMonth()
        {
            List<OrderWithCustomer> ordersWithCustomer = new List<OrderWithCustomer>();
            foreach (Customer customer in ListOfCustomers)
                foreach (Order order in customer.Orders)
                    ordersWithCustomer.Add(new OrderWithCustomer(customer, order));
            return ordersWithCustomer
                .GroupBy(element => element.Order.OrderDate.ToString("Y"))
                .ToList();
        }
    }
    
    
}
