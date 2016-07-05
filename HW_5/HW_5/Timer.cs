using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public class Timer
    {
        int Amount { get; set; }
        int Time { get; set; }
        public Timer(int amount, int time)
        {
            this.Amount = amount;
            this.Time = time;
        }
        public override string ToString()
        {
            return $"For {this.Amount} elements you wasted {this.Time} ms.\r\n";
        }
    }
}
