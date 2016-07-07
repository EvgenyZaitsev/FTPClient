using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_5
{
    public class WorkWithQueue : IMyCollection
    {
        public Queue<int> MyQueue { get; set; }
        public Timer MyTimerAdd { get; set; }
        public Timer MyTimerRead { get; set; }
        public Timer MyTimerSearch { get; set; }
        public Timer MyTimerRemove { get; set; }

        public WorkWithQueue()
        {
            this.MyQueue = new Queue<int>();
        }
        public void FillList(int amount)
        {
            Random r = new Random();
            int startTime = Environment.TickCount;
            for (int i = 0; i < amount; i++)
                this.MyQueue.Enqueue(r.Next());
            int endTime = Environment.TickCount;
            MyTimerAdd = new Timer(amount, endTime - startTime);
        }
        public void ReadList()
        {
            int element;
            int startTime = Environment.TickCount;
            for (int i = 0; i < this.MyQueue.Count; i++)
            {
                element = this.MyQueue.ElementAt(i);
            }
            int endTime = Environment.TickCount;
            MyTimerRead = new Timer(this.MyQueue.Count, endTime - startTime);
        }
        public void FindInList()
        {
            Random r = new Random();
            int element = this.MyQueue.ElementAt(r.Next(this.MyQueue.Count));
            int startTime = Environment.TickCount;
            this.MyQueue.Contains(element);
            int endTime = Environment.TickCount;
            MyTimerSearch = new Timer(this.MyQueue.Count, endTime - startTime);
        }
        public void RemoveFromList()
        {
            Random r = new Random();
            int element = this.MyQueue.ElementAt(r.Next(this.MyQueue.Count / 3, 2 * this.MyQueue.Count / 3));
            int startTime = Environment.TickCount;
            int newElement;
            do
            {
                newElement = this.MyQueue.Dequeue();
            } while (newElement != element);
            int endTime = Environment.TickCount;
            MyTimerRemove = new Timer(this.MyQueue.Count + 1, endTime - startTime);
        }
    }
}
