using System;
using System.Collections.Generic;
using System.IO;

namespace HW_2
{
    class WorkWithText
    {
        public string Text { get; set; }
        public List<string> Sentences { get; set; }

        public void Initiate(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    this.Text = sr.ReadToEnd();
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
            string[] tempSeparation = this.Text.Split(delimeters);
            this.Sentences = new List<string>(tempSeparation);
            int i = -1;
            while (++i < this.Sentences.Count)
            {
                this.Sentences[i] = this.Sentences[i].Trim() + ".";
            }
            if (Sentences[Sentences.Count - 1] == ".")
                Sentences.RemoveAt(Sentences.Count - 1);
        }
        public void ToLowCase()
        {
            int i = -1;
            while (++i < this.Sentences.Count)
            {
                this.Sentences[i] = this.Sentences[i].ToLower();
            }
        }
        public void AddLine()
        {
            int i = -1;
            while (++i < this.Sentences.Count)
            {
                this.Sentences[i] += "\r\n";
            }
        }
        public void AddTimeStamp()
        {
            int i = -1;
            while (++i < this.Sentences.Count)
            {
                this.Sentences[i] = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss:") + DateTime.Now.Millisecond + " " + this.Sentences[i];
            }
        }
        public void Print(string path)
        {
            using (StreamWriter sr = new StreamWriter(path))
            {
                int i = -1;
                while (++i < this.Sentences.Count)
                {
                    sr.Write(this.Sentences[i]);
                }
            }
        }
    }
}
