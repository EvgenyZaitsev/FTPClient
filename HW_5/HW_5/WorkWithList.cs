using System;
using System.Collections.Generic;

namespace HW_5
{
    public class WorkWithList : IMyCollection
    {
        public List<int> MyList { get; set; }
        public List<Timer> MyTimerAdd { get; set; }
        public List<Timer> MyTimerRead { get; set; }
        public List<Timer> MyTimerSearch { get; set; }
        public List<Timer> MyTimerRemove { get; set; }

        public WorkWithList()
        {
            this.MyList = new List<int>();
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
                this.MyList.Add(r.Next());
            int endTime = Environment.TickCount;
            MyTimerAdd.Add(new Timer(amount, endTime - startTime));
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
            MyTimerRead.Add(new Timer(this.MyList.Count, endTime - startTime));
        }
        public void FindInList()
        {
            Random r = new Random();
            int element = this.MyList[r.Next(this.MyList.Count)];
            int startTime = Environment.TickCount;
            int newElement = this.MyList.Find(x => x == element);
            int endTime = Environment.TickCount;
            MyTimerSearch.Add(new Timer(this.MyList.Count, endTime - startTime));
        }
        public void RemoveFromList()
        {
            Random r = new Random();
            int element = this.MyList[r.Next(this.MyList.Count / 3, 2 * this.MyList.Count / 3)];
            int startTime = Environment.TickCount;
            this.MyList.Remove(element);
            int endTime = Environment.TickCount;
            MyTimerRemove.Add(new Timer(this.MyList.Count + 1, endTime - startTime));
        }
    }
}
