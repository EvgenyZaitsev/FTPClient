using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_5
{
    public class WorkWithSortedSet : IMyCollection
    {
        public SortedSet<int> MySortedSet { get; set; }
        public Timer MyTimerAdd { get; set; }
        public Timer MyTimerRead { get; set; }
        public Timer MyTimerSearch { get; set; }
        public Timer MyTimerRemove { get; set; }

        public WorkWithSortedSet()
        {
            this.MySortedSet = new SortedSet<int>();
        }
        public void FillList(int amount)
        {
            Random r = new Random();
            int startTime = Environment.TickCount;
            for (int i = 0; i < amount; i++)
                this.MySortedSet.Add(r.Next());
            int endTime = Environment.TickCount;
            MyTimerAdd = new Timer(amount, endTime - startTime);
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
            MyTimerRead = new Timer(this.MySortedSet.Count, endTime - startTime);
        }
        public void FindInList()
        {
            Random r = new Random();
            int element = this.MySortedSet.ElementAt(r.Next(this.MySortedSet.Count));
            int startTime = Environment.TickCount;
            this.MySortedSet.Contains(element);
            int endTime = Environment.TickCount;
            MyTimerSearch = new Timer(this.MySortedSet.Count, endTime - startTime);
        }
        public void RemoveFromList()
        {
            Random r = new Random();
            int element = this.MySortedSet.ElementAt(r.Next(this.MySortedSet.Count / 3, 2 * this.MySortedSet.Count / 3));
            int startTime = Environment.TickCount;
            this.MySortedSet.Remove(element);            
            int endTime = Environment.TickCount;
            MyTimerRemove = new Timer(this.MySortedSet.Count + 1, endTime - startTime);
        }
    }
}
