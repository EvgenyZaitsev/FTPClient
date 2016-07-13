using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_1
{
    public class Logger
    {
        private string Path { get; set; }
        public Logger(string path)
        {
            this.Path = path;
        }
        public void Log(string message)
        {
            string log = DateTime.Now.ToString("F");
            log += "\t" + message + "\r\n";
            if (System.IO.File.Exists(this.Path))
            {
                System.IO.File.AppendAllText(this.Path, log);
            }
            else
            {
                var stream = System.IO.File.Create(this.Path);
                stream.Close();
                System.IO.File.AppendAllText(this.Path, log);
            }
        }
    }
}
