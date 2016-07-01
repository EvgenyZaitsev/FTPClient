using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_4
{
    public class ListOfItems
    {
        Dictionary<string, double> listOfItems { get; set; }
        public ListOfItems()
        {
            listOfItems = new Dictionary<string, double>();
        }
        public void AddItem(string name, double price)
        {
            if (!listOfItems.ContainsKey(name))
                listOfItems.Add(name, price);
            else Console.WriteLine("This item already exist");
        }
        public bool Contains(string item)
        {
            if (listOfItems.ContainsKey(item))
                return true;
            return false;
        }
        public double getValue(string item)
        {
            return listOfItems[item];
        }
        public void RemoveItem(string name)
        {
            if (!listOfItems.ContainsKey(name))
                Console.WriteLine("No such element found.");             
            else listOfItems.Remove(name);
        }
        public void ShowList()
        {
            foreach (KeyValuePair<string, double> pair in listOfItems)
            {
                Console.WriteLine(pair.Key + "     " + pair.Value);
            }
        }
    }
}
