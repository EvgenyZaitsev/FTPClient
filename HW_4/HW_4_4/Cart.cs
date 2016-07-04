using System;
using System.Collections.Generic;

namespace HW_4_4
{
    public class Cart
    {
        public Dictionary<Item, int> cart { set; get; }
        public Cart()
        {
            cart = new Dictionary<Item, int>();
        }
        public void AddItem(Item item)
        {
            if (cart.ContainsKey(item))
                cart[item]++;
            else
                cart.Add(item, 1);
        }
        public void RemoveItem(Item item)
        {
            if (cart.ContainsKey(item))
                if (cart[item] > 1)
                    cart[item]--;
                else cart.Remove(item);
            else Console.WriteLine($"No element \"{item.Name}\" in cart.");
        }
        public double TotalCost()
        {
            double cost = 0;
            foreach (KeyValuePair<Item, int> item in cart)
                cost += item.Key.Price * item.Value;
            return cost;
        }
        public string CartContains()
        {
            string content = "";
            if (cart.Count == 0)
            {
                content = "empty";
                return content;
            }
            else
            {
                content += "\r\n";
                string name;
                string price;
                int amount;
                foreach (KeyValuePair<Item, int> item in cart)
                {
                    name = item.Key.Name;
                    if (name.Length > 20)
                        name = name.Substring(0, 20);
                    while(name.Length < 20)
                            name += " ";
                    price = item.Key.Price.ToString();
                    if (price.Length > 10)
                        price = price.Substring(0, 10);
                    while (price.Length < 10)
                        price += " ";
                    amount = item.Value;
                    content += name + price + amount + "\r\n";
                }
                return content;
            }
        }
    }
}
