using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_5
{
    public class WorkWithStack : IMyCollection
    {
        public Stack<int> MyStack { get; set; }
        public Timer MyTimerAdd { get; set; }
        public Timer MyTimerRead { get; set; }
        public Timer MyTimerSearch { get; set; }
        public Timer MyTimerRemove { get; set; }

        public WorkWithStack()
        {
            this.MyStack = new Stack<int>();
        }
        public void FillList(int amount)
        {
            Random r = new Random();
            int startTime = Environment.TickCount;
            for (int i = 0; i < amount; i++)
                this.MyStack.Push(r.Next());
            int endTime = Environment.TickCount;
            MyTimerAdd = new Timer(amount, endTime - startTime);
        }
        public void ReadList()
        {
            int element;
            int startTime = Environment.TickCount;
            for (int i = 0; i < this.MyStack.Count; i++)
            {
                element = this.MyStack.ElementAt(i);
            }
            int endTime = Environment.TickCount;
            MyTimerRead = new Timer(this.MyStack.Count, endTime - startTime);
        }
        public void FindInList()
        {
            Random r = new Random();
            int element = this.MyStack.ElementAt(r.Next(this.MyStack.Count));
            int startTime = Environment.TickCount;
            this.MyStack.Contains(element);
            int endTime = Environment.TickCount;
            MyTimerSearch = new Timer(this.MyStack.Count, endTime - startTime);
        }
        public void RemoveFromList()
        {
            Random r = new Random();
            int element = this.MyStack.ElementAt(r.Next(this.MyStack.Count / 3, 2 * this.MyStack.Count / 3));
            int startTime = Environment.TickCount;
            int newElement;
            do
            {
                newElement = this.MyStack.Pop();
            } while (newElement != element);
            int endTime = Environment.TickCount;
            MyTimerRemove = new Timer(this.MyStack.Count + 1, endTime - startTime);
        }
    }
}
