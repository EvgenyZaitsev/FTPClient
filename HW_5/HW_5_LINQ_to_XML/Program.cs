using System;

namespace HW_5_LINQ_to_XML
{
    class Program
    {
        static void Main(string[] args)
       {
            Customers customers = new Customers();
            customers.ReadDataFromXML();
            //Console.WriteLine("1. Customers with summary orders more than 5000");
            //foreach (var customer in customers.CustomersWithMoreThanXOrderSums(5000))
            //    Console.WriteLine(customer);
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("2. Customers grouped by country");
            //foreach (var g in customers.GroupCustomersByContry())
            //{
            //    Console.WriteLine(g.Key);
            //    foreach(var customer in g)
            //        Console.WriteLine(customer);
            //}
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine($"3. Customers with orders more than 2000\r\n");
            //foreach (var customer in customers.CustomersWithMoreThanXOrder(2000))
            //    Console.WriteLine(customer);
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine($"4. Customers with their first orders\r\n");
            //foreach (var customer in customers.ListOfFirstOrder())
            //    Console.WriteLine(customer);
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine($"5. Customers with their first orders sorted by date and name\r\n");
            //foreach (var customer in customers.SortedListOfFirstOrder())
            //    Console.WriteLine(customer);
            //Console.ReadKey();
            //Console.Clear();

            Console.WriteLine($"6. Customers with Letters in postal code ore without phone code\r\n");
            foreach (var customer in customers.CustomersWithLettersInPostalCodeNoRegionNoOperatorCode())
                Console.WriteLine(customer);
            Console.ReadKey();
            Console.Clear();

            //Console.WriteLine($"7. Average sum and intencity for cities\r\n");
            //foreach (var customer in customers.CityWithAverageSumAndAverageIntencity())
            //    Console.WriteLine(customer);
            //Console.ReadKey();
            //Console.Clear();

            Console.WriteLine($"8.1. Statistics by years\r\n");
            foreach (var customer in customers.StatisticsByYear())
            {
                Console.WriteLine(customer.Key);
                foreach (var value in customer)
                    Console.WriteLine(value);
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"8.2. Statistics by monthes\r\n");
            foreach (var customer in customers.StatisticsByMonth())
            {
                Console.WriteLine(customer.Key);
                foreach (var value in customer)
                    Console.WriteLine(value);
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"8.3. Statistics by years and monthes\r\n");
            foreach (var customer in customers.StatisticsByYearAndMonth())
            {
                Console.WriteLine(customer.Key);
                foreach (var value in customer)
                    Console.WriteLine(value);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
