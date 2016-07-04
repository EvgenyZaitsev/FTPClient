using System;
using HW_4_1;
using HW_4_2;
using HW_4_3;
using HW_4_4;
using HW_4_5;
using System.Numerics;

namespace HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithPoints();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            WorkWithFibAndFact();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            WorkWithSelfCountableClass();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            WorkWithRectangles();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            WorkWithCart();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void WorkWithPoints()
        {
            Console.WriteLine("Working with points.");
            Point p1 = new Point(2.0, 5.0);
            Point p2 = new Point(3.0, 5.0);
            Point p3 = new Point(2.0, 5.0);
            Console.WriteLine($"Point 1 is {p1.ToString()}");
            Console.WriteLine($"Point 2 is {p2.ToString()}");
            Console.WriteLine($"Point 3 is {p3.ToString()}");
            Console.WriteLine("Are points equals?");
            Console.WriteLine($"Point 1 and Point 2: {p1.Equals(p2).ToString()}.");
            Console.WriteLine($"Point 1 and Point 3: {p1.Equals(p3).ToString()}.");
            Console.WriteLine($"Point 2 and Point 3: {p2.Equals(p3).ToString()}.");
        }
        static void WorkWithFibAndFact()
        {
            Console.WriteLine("Working with Fibonacci sequence and factorials.");
            FibAndFact[] faf = new FibAndFact[5];
            for (int i = 0; i < 5; i++)
             {
                faf[i] = new FibAndFact((int)Math.Pow(10, i));
             }
            for (int i = 0; i < 5; i++)
             {
                Console.WriteLine($"Index is {faf[i].Index}.");
                Console.WriteLine($"Factorial is {faf[i].FactTree()}.");
                Console.WriteLine($"Fibonacci number is {faf[i].Fib().ToString("0.")}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
             }
         }
        static void WorkWithSelfCountableClass()
         {
            Console.WriteLine("Working with Self countable class.");
            for (int i = 0; i < 20; i++)
            {
                SelfCountableClass scc = new SelfCountableClass();
                Console.WriteLine($"Instance of class ({i + 1}) succesfully created.");
                if (i % 5 == 0)
                    Console.WriteLine($"Amount of created instances of class is {scc.I}");
                Console.WriteLine();
            }
         }
        static void WorkWithRectangles()
        {
            Rectangles[] rectangles = new Rectangles[8];
            rectangles[0] = new Rectangles(11, 12, 2, 3);
            rectangles[1] = new Rectangles(12, 11, 2, 3);
            rectangles[2] = new Rectangles(11, 12, 3, 2);
            rectangles[3] = new Rectangles(12, 11, 3, 2);

            rectangles[4] = new Rectangles(87, 34, 5, 2);
            rectangles[5] = new Rectangles(87, 34, 2, 5);
            rectangles[6] = new Rectangles(34, 86, 5, 2);
            rectangles[7] = new Rectangles(34, 86, 2, 5);
            for (int i = 0; i < 8; i++)
                Console.WriteLine($"Amount of rectangles with sides {rectangles[i].HeightTwo} and {rectangles[i].WidthTwo} in rectangle {rectangles[i].HeightOne} and {rectangles[i].WidthOne} is {rectangles[i].TotalAmount()}");
         }
        static void WorkWithCart()
         {
            Cart cart = new Cart();
            Item[] items = new Item[5];
            items[0] = new Item("banana", 2.5);
            items[1] = new Item("pizza", 5.1);
            items[2] = new Item("ice cream", 1.2);
            items[3] = new Item("barbecue", 6.0);
            items[4] = new Item("carrot", 0.5);

            cart.AddItem(items[0]);
            cart.AddItem(items[1]);
            cart.AddItem(items[2]);
            cart.AddItem(items[3]);
            Console.WriteLine($"Your cart is {cart.CartContains()}");
            Console.WriteLine($"Total cost of the cart is {cart.TotalCost()}");
            cart.AddItem(items[0]);
            cart.AddItem(items[1]);
            cart.AddItem(items[2]);
            Console.WriteLine($"Your cart is {cart.CartContains()}");
            Console.WriteLine($"Total cost of the cart is {cart.TotalCost()}");
            cart.RemoveItem(items[3]);
            cart.RemoveItem(items[4]);
            Console.WriteLine($"Your cart is {cart.CartContains()}");
            Console.WriteLine($"Total cost of the cart is {cart.TotalCost()}");
         }
    }
}
