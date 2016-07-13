using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_5_LINQ_to_XML;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_to_XML_Tests
{
    [TestClass]
    public class LINQ_to_XML_Tests
    {
        [ClassInitialize]
        static public void ClassInit(TestContext context)
        {
            Console.WriteLine($"ClassInit {context.TestName}");
        }
        [ClassCleanup]
        static public void ClassCleanup()
        {
            Console.WriteLine($"ClassCleanup");
        }
        [TestInitialize]
        public void Init()
        {
            Console.WriteLine($"TestMethodInit");
        }
        [TestCleanup]
        public void Cleanup()
        {
            Console.WriteLine($"TestMethodleanup");
        }

        [TestMethod]
        public void CheckForSumOrders()
        {
            Customers customers = new Customers();
            customers.ReadDataFromXML();
            int length1 = customers.CustomersWithMoreThanXOrderSums(5000).Count;
            int length2 = customers.CustomersWithMoreThanXOrderSums(6000).Count;
            Assert.AreNotEqual(length1, length2, 1, "Amount of clients is equal for orders sum 5000 and 6000");
        }

        [TestMethod]
        public void CheckForCountries()
        {
            Customers customers = new Customers();
            customers.ReadDataFromXML();
            int length1 = customers.GroupCustomersByContry().Count;
            customers.ListOfCustomers.Add(new Customer("abc", "Jonh", "no address", "Leningrad", "ABC", "Mother Russia", "1234567", "1234567", null, new List<Order>() { new Order("123", default(DateTime), 88888888.88) }));
            int length2 = customers.GroupCustomersByContry().Count;
            Assert.AreNotEqual(length1, length2, 0, "No customers from this country");
        }

        [TestMethod]
        public void CheckForOrders()
        {
            Customers customers = new Customers();
            customers.ReadDataFromXML();
            int length1 = customers.CustomersWithMoreThanXOrder(2000).Count;
            int length2 = customers.CustomersWithMoreThanXOrder(2500).Count;
            Assert.AreNotEqual(length1, length2, 1, "Amount of clients is equal for orders more than 2000 and 2500");
        }

        [TestMethod]
        public void CheckForFirstOrder()
        {
            Customers customers = new Customers();
            customers.ReadDataFromXML();
            var length1 = customers.ListOfFirstOrder().Count;
            customers.ListOfCustomers.Add(new Customer("abc", "Jonh", "no address", "Leningrad", "ABC", "Mother Russia", "1234567", "1234567", null, new List<Order>() { new Order("123", default(DateTime), 88888888.88) }));
            var length2 = customers.ListOfFirstOrder().Count;
            Assert.AreNotEqual(length1, length2, 0, "No customers after 1996");
        }

        [TestMethod]
        public void CheckForWrongData()
        {
            Customers customers = new Customers();
            customers.ReadDataFromXML();
            int length1 = customers.CustomersWithLettersInPostalCodeNoRegionNoOperatorCode().Count;
            customers.ListOfCustomers.Add(new Customer("abc", "Jonh", "no address", "Moscow", "ABC", "Russia", "1234567", "1234567", null, null));
            int length2 = customers.CustomersWithLettersInPostalCodeNoRegionNoOperatorCode().Count;
            Assert.AreNotEqual(length1, length2, 0, "Something went wrong");
        }

        [TestMethod]
        public void CheckForCitiesStats()
        {
            Customers customers = new Customers();
            customers.ReadDataFromXML();
            var city1 = customers.CityWithAverageSumAndAverageIntencity()[0];
            customers.ListOfCustomers.Add(new Customer("abc", "Jonh", "no address", city1.City, "ABC", "Russia", "1234567", "1234567", null, new List<Order> (){new Order("123", default(DateTime), 88888888.88)}));
            var newCity1= customers.CityWithAverageSumAndAverageIntencity()[0];
            Assert.AreNotEqual(city1.AverageSum, newCity1.AverageSum, 5, "Something went wrong");
        }


    }
}
