using System;
using System.Collections.Generic;

namespace HW_2
{
    class Text
    {
        List<string> data;
        List<Current_Element> dataWithType;
        public void Read()
        {
            data = new List<string>();
            string str;
            while ((str = Console.ReadLine()) != "/e")
            {
                data.Add(str);
            }
        }
        public void SetType()
        {
            dataWithType = new List<Current_Element>();
            foreach (string s in data)
            {
                Current_Element c;
                int i;
                if (Int32.TryParse(s, out i))
                {
                    c = new Current_Element(s, "Integer");
                    dataWithType.Add(c);
                    continue;
                }
                double d;
                if (Double.TryParse(s, out d))
                {
                    c = new Current_Element(s.Replace(',', '.'), "Double");
                    dataWithType.Add(c);
                    continue;
                }
                c = new Current_Element(s, "String");
                dataWithType.Add(c);
                continue;

            }
        }
        public void Print()
        {
            foreach (Current_Element ce in dataWithType)
            {
                ce.Print();
            }
        }
        public int CountInteger()
        {
            int counter = 0;
            foreach (Current_Element ce in dataWithType)
            {
                if (ce.GetTypeOfElement() == "Integer")
                {
                    counter++;
                }
            }
            return counter;
        }
        public int CountDouble()
        {
            int counter = 0;
            foreach (Current_Element ce in dataWithType)
            {
                if (ce.GetTypeOfElement() == "Double")
                {
                    counter++;
                }
            }
            return counter;
        }
        public void PrintInteger()
        {
            Console.WriteLine("Integer numbers:");
            int i = 0;
            foreach (Current_Element ce in dataWithType)
            {
                if (ce.GetTypeOfElement() == "Integer")
                {
                    Console.WriteLine(ce.GetElement().PadLeft(20));
                    i++;
                }
            }
            if (i != 0)
                Console.WriteLine(("Average is " + AverageInteger()).PadLeft(20));
            else
                Console.WriteLine(("Average is not available").PadLeft(20));
            Console.WriteLine();
        }
        public void PrintDouble()
        {
            int i = 0;
            Console.WriteLine("Double numbers:");
            foreach (Current_Element ce in dataWithType)
            {
                if (ce.GetTypeOfElement() == "Double")
                {
                    if (ce.GetElement().IndexOf('.') != -1)
                        Console.WriteLine(ce.GetElement().Substring(0, Math.Min(ce.GetElement().IndexOf(".") + 2, ce.GetElement().Length)).PadLeft(20));
                    else
                        Console.WriteLine(ce.GetElement().PadLeft(20));
                    i++;
                }
            }
            if (i != 0)
                Console.WriteLine(("Average is " + AverageDouble()).PadLeft(20));
            else
                Console.WriteLine(("Average is not available").PadLeft(20));
            Console.WriteLine();
        }
        public void PrintString()
        {
            Console.WriteLine("List of strings:");
            List<string> strings = new List<string>();
            foreach (Current_Element ce in dataWithType)
            {
                if (ce.GetTypeOfElement() == "String")
                {
                    strings.Add(ce.GetElement());
                }
            }
            strings.Sort(CompareByLength);
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }

        }
        public double AverageInteger()
        {
            int counter = CountInteger();
            int sum = 0;
            foreach (Current_Element ce in dataWithType)
            {
                if (ce.GetTypeOfElement() == "Integer")
                {
                    sum += Int32.Parse(ce.GetElement());
                }
            }
            return (double)sum / (double)counter;
        }
        public double AverageDouble()
        {
            int counter = CountDouble();
            double sum = 0;
            foreach (Current_Element ce in dataWithType)
            {
                if (ce.GetTypeOfElement() == "Double")
                {
                    sum += Double.Parse(ce.GetElement());
                }
            }
            return (double)sum / (double)counter;
        }
        private static int CompareByLength(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y == null)
                // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the 
                    // lengths of the two strings.
                    //
                    int retval = x.Length.CompareTo(y.Length);

                    if (retval != 0)
                    {
                        // If the strings are not of equal length,
                        // the longer string is greater.
                        //
                        return retval;
                    }
                    else
                    {
                        // If the strings are of equal length,
                        // sort them with ordinary string comparison.
                        //
                        return x.CompareTo(y);
                    }
                }
            }
        }
    }
}
