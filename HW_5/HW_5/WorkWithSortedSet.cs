using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_5
{
    public class WorkWithSortedSet : IMyCollection
    {
        public SortedSet<int> MySortedSet { get; set; }
        public List<Timer> MyTimerAdd { get; set; }
        public List<Timer> MyTimerRead { get; set; }
        public List<Timer> MyTimerSearch { get; set; }
        public List<Timer> MyTimerRemove { get; set; }

        public WorkWithSortedSet()
        {
            this.MySortedSet = new SortedSet<int>();
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
                this.MySortedSet.Add(r.Next());
            int endTime = Environment.TickCount;
            MyTimerAdd.Add(new Timer(amount, endTime - startTime));
        }
        public void ReadList()
        {
            int element;
            int startTime = Environment.TickCount;
            for (int i = 0; i < this.MySortedSet.Count; i++)
            {
                element = this.MySortedSet.ElementAt(i);
            }
            int endTime = Environment.TickCount;
            MyTimerRead.Add(new Timer(this.MySortedSet.Count, endTime - startTime));
        }
        public void FindInList()
        {
            Random r = new Random();
            int element = this.MySortedSet.ElementAt(r.Next(this.MySortedSet.Count));
            int startTime = Environment.TickCount;
            this.MySortedSet.Contains(element);
            int endTime = Environment.TickCount;
            MyTimerSearch.Add(new Timer(this.MySortedSet.Count, endTime - startTime));
        }
        public void RemoveFromList()
        {
            Random r = new Random();
            int element = this.MySortedSet.ElementAt(r.Next(this.MySortedSet.Count / 3, 2 * this.MySortedSet.Count / 3));
            int startTime = Environment.TickCount;
            this.MySortedSet.Remove(element);            
            int endTime = Environment.TickCount;
            MyTimerRemove.Add(new Timer(this.MySortedSet.Count + 1, endTime - startTime));
        }
    }
}
