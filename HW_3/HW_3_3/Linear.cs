using System;

namespace HW_3_3
{
    public class Linear
    {
        public double A { get; set; }
        public double B { get; set; }
        public string Solve { get; set; }

        public Linear (double a, double b)
        {
            this.A = a;
            this.B = b;
        }
        public void FindSolution()
        {
            if (this.A != 0)
            {
                this.Solve = "x = ";
                this.Solve += (-this.B / this.A).ToString("0.00");
                return;
            }
            if (this.A == 0 && this.B == 0)
            {
                this.Solve = "x may be any number";
                return;
            }
            if (this.A == 0 && this.B != 0)
            {
                this.Solve = "there is no solutions";
                return;
            }
        }

    }
}
