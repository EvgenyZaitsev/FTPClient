using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_5
{
    public class WorkWithDictionary : IMyCollection
    {
        public Dictionary<int, int> MyDictionary { get; set; }
        public Timer MyTimerAdd { get; set; }
        public Timer MyTimerRead { get; set; }
        public Timer MyTimerSearch { get; set; }
        public Timer MyTimerRemove { get; set; }

        public WorkWithDictionary()
        {
            this.MyDictionary = new Dictionary<int, int>();
        }
        public void FillList(int amount)
        {
            Random r = new Random();
            int startTime = Environment.TickCount;
            for (int i = 0; i < amount; i++)
                this.MyDictionary.Add(i, r.Next());
            int endTime = Environment.TickCount;
            MyTimerAdd = new Timer(amount, endTime - startTime);
        }
        public void ReadList()
        {
            int element;
            int startTime = Environment.TickCount;
            for (int i = 0; i < this.MyDictionary.Count; i++)
            {
                element = this.MyDictionary[i];
            }
            int endTime = Environment.TickCount;
            MyTimerRead = new Timer(this.MyDictionary.Count, endTime - startTime);
        }
        public void FindInList()
        {
            Random r = new Random();
            int element = this.MyDictionary[r.Next(this.MyDictionary.Count)];
            int startTime = Environment.TickCount;
            KeyValuePair<int, int> newElement = this.MyDictionary.First(x => x.Value == element);
            int endTime = Environment.TickCount;
            MyTimerSearch = new Timer(this.MyDictionary.Count, endTime - startTime);
        }
        public void RemoveFromList()
        {
            Random r = new Random();
            int element = this.MyDictionary[r.Next(this.MyDictionary.Count / 3, 2 * this.MyDictionary.Count / 3)];
            int startTime = Environment.TickCount;
            this.MyDictionary.Remove(r.Next(this.MyDictionary.Count / 3, 2 * this.MyDictionary.Count / 3));
            int endTime = Environment.TickCount;
            MyTimerRemove = new Timer(this.MyDictionary.Count + 1, endTime - startTime);
        }
    }
}
