using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_5
{
    public class WorkWithLinkedList : IMyCollection
    {
        public LinkedList<int> MyLinkedList { get; set; }
        public Timer MyTimerAdd { get; set; }
        public Timer MyTimerRead { get; set; }
        public Timer MyTimerSearch { get; set; }
        public Timer MyTimerRemove { get; set; }

        public WorkWithLinkedList()
        {
            this.MyLinkedList = new LinkedList<int>();
        }
        public void FillList(int amount)
        {
            Random r = new Random();
            int startTime = Environment.TickCount;
            for (int i = 0; i < amount; i++)
                this.MyLinkedList.AddFirst(r.Next());
            int endTime = Environment.TickCount;
            MyTimerAdd= new Timer(amount, endTime - startTime);
        }
        public void ReadList()
        {
            int element;
            int startTime = Environment.TickCount;
            for (int i = 0; i < this.MyLinkedList.Count; i++)
            {
                element = this.MyLinkedList.ElementAt(i);
            }
            int endTime = Environment.TickCount;
            MyTimerRead= new Timer(this.MyLinkedList.Count, endTime - startTime);
        }
        public void FindInList()
        {
            Random r = new Random();
            int element = this.MyLinkedList.ElementAt(r.Next(this.MyLinkedList.Count));
            int startTime = Environment.TickCount;
            LinkedListNode<int> newElement = this.MyLinkedList.Find(element);
            int endTime = Environment.TickCount;
            MyTimerSearch = new Timer(this.MyLinkedList.Count, endTime - startTime);
        }
        public void RemoveFromList()
        {
            Random r = new Random();
            int element = this.MyLinkedList.ElementAt(r.Next(this.MyLinkedList.Count / 3, 2 * this.MyLinkedList.Count / 3));
            int startTime = Environment.TickCount;
            this.MyLinkedList.Remove(element);
            int endTime = Environment.TickCount;
            MyTimerRemove = new Timer(this.MyLinkedList.Count + 1, endTime - startTime);
        }
    }
}
