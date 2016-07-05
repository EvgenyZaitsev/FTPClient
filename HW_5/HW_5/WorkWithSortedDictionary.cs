using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_5
{
    public class WorkWithSortedDictionary : IMyCollection
    {
        public SortedDictionary<int, int> MySortedDictionary { get; set; }
        public List<Timer> MyTimerAdd { get; set; }
        public List<Timer> MyTimerRead { get; set; }
        public List<Timer> MyTimerSearch { get; set; }
        public List<Timer> MyTimerRemove { get; set; }

        public WorkWithSortedDictionary()
        {
            this.MySortedDictionary = new SortedDictionary<int, int>();
            this.MyTimerAdd = new List<Timer>();
            this.MyTimerRead = new List<Timer>();
            this.MyTimerSearch = new List<Timer>();
            this.MyTimerRemove = new List<Timer>();
        }
        public void FillList(int amount)
        {
            Random r = new Random();
            int startTime = Environment.TickCount;
            for (int i = 0; i < amount; i++)
                this.MySortedDictionary.Add(i, r.Next());
            int endTime = Environment.TickCount;
            MyTimerAdd.Add(new Timer(amount, endTime - startTime));
        }
        public void ReadList()
        {
            int element;
            int startTime = Environment.TickCount;
            for (int i = 0; i < this.MySortedDictionary.Count; i++)
            {
                element = this.MySortedDictionary[i];
            }
            int endTime = Environment.TickCount;
            MyTimerRead.Add(new Timer(this.MySortedDictionary.Count, endTime - startTime));
        }
        public void FindInList()
        {
            Random r = new Random();
            int element = this.MySortedDictionary[r.Next(this.MySortedDictionary.Count)];
            int startTime = Environment.TickCount;
            KeyValuePair<int, int> newElement = this.MySortedDictionary.First(x => x.Value == element);
            int endTime = Environment.TickCount;
            MyTimerSearch.Add(new Timer(this.MySortedDictionary.Count, endTime - startTime));
        }
        public void RemoveFromList()
        {
            Random r = new Random();
            int element = this.MySortedDictionary[r.Next(this.MySortedDictionary.Count / 3, 2 * this.MySortedDictionary.Count / 3)];
            int startTime = Environment.TickCount;
            this.MySortedDictionary.Remove(r.Next(this.MySortedDictionary.Count / 3, 2 * this.MySortedDictionary.Count / 3));
            int endTime = Environment.TickCount;
            MyTimerRemove.Add(new Timer(this.MySortedDictionary.Count + 1, endTime - startTime));
        }
    }
}
