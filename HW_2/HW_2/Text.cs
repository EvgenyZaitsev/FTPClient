using System;
using System.Collections.Generic;
using System.IO;

namespace HW_2
{
    class Text
    {
        private string text;
        List<string> sentences;

        public void Initiate(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    text = sr.ReadToEnd();
                }
            }
            else
            {
                Console.WriteLine("No such file! Please, add an existing file!");
                Environment.Exit(-1);
            }
        }
        public void Split()
        {
            char[] delimeters = { '!', '.', '?' };
            string[] tempSeparation = text.Split(delimeters);
            sentences = new List<string>(tempSeparation);
            int i = -1;
            while (++i < sentences.Count)
            {
                sentences[i] = sentences[i].Trim() + ".";
            }
        }
        public void ToLowCase()
        {
            int i = -1;
            while (++i < sentences.Count)
            {
                sentences[i] = sentences[i].ToLower();
            }
        }
        public void AddLine()
        {
            int i = -1;
            while (++i < sentences.Count)
            {
                sentences[i] += "\n\r";
            }
        }
        public void AddTimeStamp()
        {
            int i = -1;
            while (++i < sentences.Count)
            {
                sentences[i] = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss:") + DateTime.Now.Millisecond + " " + sentences[i];
            }
        }
        public void Print(string path)
        {
            using (StreamWriter sr = new StreamWriter(path))
            {
                int i = -1;
                while (++i < sentences.Count)
                {
                    sr.WriteLine(sentences[i]);
                }
            }
        }
    }
}
