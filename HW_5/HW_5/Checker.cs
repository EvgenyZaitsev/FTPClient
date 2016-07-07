using System;
using System.Collections.Generic;
using System.IO;

namespace HW_5
{
    public class Checker
    {
        public string Path { get; set; }
        public Checker(string path)
        {
            this.Path = path;
        }
        public void CheckList(int n)
        {
            for (int i = 0; i < n; i++)
            {
                WorkWithList wwl = new WorkWithList();
                int amount = (int)Math.Pow(10, i + 3);
                wwl.FillList(amount);
                wwl.ReadList();
                wwl.FindInList();
                wwl.RemoveFromList();
                List<List<Timer>> llt = new List<List<Timer>>();
                llt.Add(wwl.MyTimerAdd);
                llt.Add(wwl.MyTimerRead);
                llt.Add(wwl.MyTimerSearch);
                llt.Add(wwl.MyTimerRemove);
                Logger log = new Logger();
                log.Log("List", llt, this.Path);
            }
        }
        public void CheckLinkedList(int n)
        {
            for (int i = 0; i < n; i++)
            {
                WorkWithLinkedList wwll = new WorkWithLinkedList();
                int amount = (int)Math.Pow(10, i + 3);
                wwll.FillList(amount);
                wwll.ReadList();
                wwll.FindInList();
                wwll.RemoveFromList();
                List<List<Timer>> llt = new List<List<Timer>>();
                llt.Add(wwll.MyTimerAdd);
                llt.Add(wwll.MyTimerRead);
                llt.Add(wwll.MyTimerSearch);
                llt.Add(wwll.MyTimerRemove);
                Logger log = new Logger();
                log.Log("Linked List", llt, this.Path);
            }
        }
        public void CheckDictionary(int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                List<List<Timer>> llt = new List<List<Timer>>();
                Logger log = new Logger();
                WorkWithDictionary wwd = new WorkWithDictionary();
                int amount = (int)Math.Pow(10, i + 3);
                wwd.FillList(amount);
                wwd.ReadList();
                wwd.FindInList();
                wwd.RemoveFromList();
                llt.Add(wwd.MyTimerAdd);
                llt.Add(wwd.MyTimerRead);
                llt.Add(wwd.MyTimerSearch);
                llt.Add(wwd.MyTimerRemove);
                log.Log("Dictionary", llt, this.Path);
            }
        }
        public void CheckSortedDictionary(int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                WorkWithSortedDictionary wwsd = new WorkWithSortedDictionary();
                int amount = (int)Math.Pow(10, i + 3);
                wwsd.FillList(amount);
                wwsd.ReadList();
                wwsd.FindInList();
                wwsd.RemoveFromList();
                List<List<Timer>> llt = new List<List<Timer>>();
                llt.Add(wwsd.MyTimerAdd);
                llt.Add(wwsd.MyTimerRead);
                llt.Add(wwsd.MyTimerSearch);
                llt.Add(wwsd.MyTimerRemove);
                Logger log = new Logger();
                log.Log("Sorted Dictionary", llt, this.Path);
            }
        }
        public void CheckQueue(int n)
        {
            for (int i = 0; i < n; i++)
            {
                WorkWithQueue wwq = new WorkWithQueue();
                int amount = (int)Math.Pow(10, i + 3);
                wwq.FillList(amount);
                wwq.ReadList();
                wwq.FindInList();
                wwq.RemoveFromList();
                List<List<Timer>> llt = new List<List<Timer>>();
                llt.Add(wwq.MyTimerAdd);
                llt.Add(wwq.MyTimerRead);
                llt.Add(wwq.MyTimerSearch);
                llt.Add(wwq.MyTimerRemove);
                Logger log = new Logger();
                log.Log("Queue", llt, this.Path);
            }
        }
        public void CheckStack(int n)
        {
            for (int i = 0; i < n; i++)
            {
                WorkWithStack wws = new WorkWithStack();
                int amount = (int)Math.Pow(10, i + 3);
                wws.FillList(amount);
                wws.ReadList();
                wws.FindInList();
                wws.RemoveFromList();
                List<List<Timer>> llt = new List<List<Timer>>();
                llt.Add(wws.MyTimerAdd);
                llt.Add(wws.MyTimerRead);
                llt.Add(wws.MyTimerSearch);
                llt.Add(wws.MyTimerRemove);
                Logger log = new Logger();
                log.Log("Stack", llt, this.Path);
            }
        }
        public void CheckSortedSet(int n)
        {
            for (int i = 0; i < n; i++)
            {
                WorkWithSortedSet wwss = new WorkWithSortedSet();
                int amount = (int)Math.Pow(10, i + 3);
                wwss.FillList(amount);
                wwss.ReadList();
                wwss.FindInList();
                wwss.RemoveFromList();
                List<List<Timer>> llt = new List<List<Timer>>();
                llt.Add(wwss.MyTimerAdd);
                llt.Add(wwss.MyTimerRead);
                llt.Add(wwss.MyTimerSearch);
                llt.Add(wwss.MyTimerRemove);
                Logger log = new Logger();
                log.Log("Sorted Set", llt, this.Path);
            }
        }
    }
}
