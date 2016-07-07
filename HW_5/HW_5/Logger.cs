using System;
using System.Collections.Generic;
using System.IO;

namespace HW_5
{
    class Logger
    {
        List<string> NameOfLists { get; set; }
        public Logger()
        {
            NameOfLists = new List<string>();
            NameOfLists.Add("Add Elements\r\n");
            NameOfLists.Add("Read Elements\r\n");
            NameOfLists.Add("Search Element\r\n");
            NameOfLists.Add("Remove Element\r\n");
        }
        public void Log(string collection, List<Timer> listOfTimers, string path)
        {
            File.AppendAllText(path, $"\r\n\r\nCollection {collection}: \r\n\r\n");
            for (int i = 0; i < 4; i++)
            {
                File.AppendAllText(path, NameOfLists[i]);
                File.AppendAllText(path, listOfTimers[i].ToString());
            }
        }
    }
}
