using System;

namespace HW_5_LINQ_to_XML
{
    public class CustomerWithDate
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public CustomerWithDate(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;
        }
        public override string ToString()
        {
            return $"{Name} + First order was made {Date.ToString("MM-YYYY")}";
        }
    }
}
