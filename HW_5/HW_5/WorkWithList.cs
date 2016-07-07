using System;
using System.Collections.Generic;

namespace HW_5
{
    public class WorkWithList : IMyCollection
    {
        public List<int> MyList { get; set; }
        public Timer MyTimerAdd { get; set; }
        public Timer MyTimerRead { get; set; }
        public Timer MyTimerSearch { get; set; }
        public Timer MyTimerRemove { get; set; }

        public WorkWithList()
        {
            this.MyList = new List<int>();
        }
        public void FillList(int amount)
        {
            Random r = new Random();
            int startTime = Environment.TickCount;
            for (int i = 0; i < amount; i++)
                this.MyList.Add(r.Next());
            int endTime = Environment.TickCount;
            MyTimerAdd = new Timer(amount, endTime - startTime);
        }
        public void ReadList()
        {
            int element;
            int startTime = Environment.TickCount;
            for (int i = 0; i < this.MyList.Count; i++)
            {
                element = this.MyList[i];
            }
            int endTime = Environment.TickCount;
            MyTimerRead = new Timer(this.MyList.Count, endTime - startTime);
        }
        public void FindInList()
        {
            Random r = new Random();
            int element = this.MyList[r.Next(this.MyList.Count)];
            int startTime = Environment.TickCount;
            int newElement = this.MyList.Find(x => x == element);
            int endTime = Environment.TickCount;
            MyTimerSearch = new Timer(this.MyList.Count, endTime - startTime);
        }
        public void RemoveFromList()
        {
            Random r = new Random();
            int element = this.MyList[r.Next(this.MyList.Count / 3, 2 * this.MyList.Count / 3)];
            int startTime = Environment.TickCount;
            this.MyList.Remove(element);
            int endTime = Environment.TickCount;
            MyTimerRemove = new Timer(this.MyList.Count + 1, endTime - startTime);
        }
    }
}
