using System;
using System.IO;

namespace HW_3_3
{
    public class Logger
    {
        private string Path { get; set; }
        public Logger(string path)
        {
            this.Path = path;
        }
        public void Log(Linear l)
        {
            string log = "Linear     ";
            if (l.B >= 0)
                log += l.A.ToString("0.00") + "x + " + l.B.ToString("0.00") + " = 0  " + l.Solve + "\r\n";
            if (l.B < 0)
                log += l.A.ToString("0.00") + "x - " + Math.Abs(l.B).ToString("0.00") + " = 0  " + l.Solve + "\r\n";
            Console.WriteLine(log);
            if (File.Exists(this.Path))
            {
                File.AppendAllText(this.Path, log);
            }
            else
            {
                File.Create(this.Path);
                File.AppendAllText(this.Path, log);
            }
        }
        public void Log(Quadratic q)
        {
            string log = "Quadratic  ";
            if (q.B >= 0)
            {

                if (q.C >= 0)
                    log += q.A.ToString("0.00") + "x^2 + " + q.B.ToString("0.00") + "x + " + q.C.ToString("0.00") + " = 0  " + q.Solve + "\r\n";
                if (q.C < 0)
                    log += q.A.ToString("0.00") + "x^2 + " + q.B.ToString("0.00") + "x - " + Math.Abs(q.C).ToString("0.00") + " = 0  " + q.Solve + "\r\n";
            }
            if (q.B < 0)
            {
                if (q.C >= 0)
                    log += q.A.ToString("0.00") + "x^2 - " + Math.Abs(q.B).ToString("0.00") + "x + " + q.C.ToString("0.00") + " = 0  " + q.Solve + "\r\n";
                if (q.C < 0)
                    log += q.A.ToString("0.00") + "x^2 - " + Math.Abs(q.B).ToString("0.00") + "x - " + Math.Abs(q.C).ToString("0.00") + " = 0  " + q.Solve + "\r\n";
            }
            Console.WriteLine(log);
            if (File.Exists(this.Path))
            {
                File.AppendAllText(this.Path, log);
            }
            else
            {
                File.Create(this.Path);
                File.AppendAllText(this.Path, log);
            }
        }
        public void LogWrong(string a, string b)
        {
            string log = "Linear     ";
            log += "Wrong data ";
            log += a + " " + b + "\r\n";
            if (File.Exists(this.Path))
            {
                File.AppendAllText(this.Path, log);
            }
            else
            {
                File.Create(this.Path);
                File.AppendAllText(this.Path, log);
            }
        }
        public void LogWrong(string a, string b, string c)
        {
            string log = "Quadratic  ";
            log += "Wrong data ";
            log += a + " " + b + " " + c + "\r\n";
            if (File.Exists(this.Path))
            {
                File.AppendAllText(this.Path, log);
            }
            else
            {
                File.Create(this.Path);
                File.AppendAllText(this.Path, log);
            }
        }
    }
}
