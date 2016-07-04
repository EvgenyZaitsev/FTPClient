using System;

namespace HW_3_3
{
    public class Quadratic
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public string Solve { get; set; }

        public Quadratic(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public void FindSolution()
        {
            if (this.A == 0)
            {
                Linear l = new Linear(this.B, this.C);
                l.FindSolution();
                this.Solve = l.Solve;
                return;
            }
            double discriminant = this.B * this.B - 4 * this.A * this.C;
            if (discriminant < 0)
            {
                this.Solve = "there is no solutions";
                return;
            }
            if (discriminant > 0)
            {
                double s1 = (-this.B + Math.Sqrt(discriminant)) / (2 * this.A);
                double s2 = (-this.B - Math.Sqrt(discriminant)) / (2 * this.A);
                this.Solve = "x = " + s1.ToString("0.00") + ", x = " + s2.ToString("0.00");
                return;
            }
            if (discriminant == 0)
            {
                double s = -this.B / (2 * this.A);
                this.Solve = "x = " + s.ToString("0.00");
                return;
            }
        }
        
    }
}
