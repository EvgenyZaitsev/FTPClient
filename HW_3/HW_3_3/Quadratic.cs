using System;

namespace HW_3_3
{
    public class Quadratic
    {
        private double a;
        private double b;
        private double c;
        private string solve;

        public Quadratic(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void FindSolution()
        {
            if (a == 0)
            {
                Linear l = new Linear(b, c);
                l.FindSolution();
                solve = l.Solve;
                return;
            }
/*
            if (a == 0 && b == 0)
                if (c == 0)
                {
                    solve = "x may be any number";
                    return;
                }
                else
                {
                    solve = "there is no solutions";
                    return;
                }
            if (a == 0 && c == 0)
                if (b != 0)
                {
                    solve = "x = 0";
                    return;
                }
                else
                {
                    solve = "x may be any number";
                    return;
                }
            if (b == 0)
            {
                if (c < 0)
                {
                    double s = Math.Sqrt(-c / a);
                    solve = "x = " + s + ", x = " + (-s);
                    return;
                }
                if (c > 0)
                {
                    solve = "there is no solutions";
                    return;
                }
                if (c == 0)
                {
                    if (a == 0)
                    {
                        solve = "x may be any number";
                        return;
                    }
                    else
                    {
                        solve = "x = 0";
                        return;
                    }
                }
            }
            if (c == 0)
            {
                Linear l = new Linear(a, b);
                l.FindSolution();
                solve = l.Sovle;
                if (solve == "there is no solutions" || solve == "x may be any number")
                    return;
                else
                    solve += ", x = 0";
            }
*/
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                solve = "there is no solutions";
                return;
            }
            if (discriminant > 0)
            {
                double s1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double s2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                solve = "x = " + s1.ToString("0.00") + ", x = " + s2.ToString("0.00");
                return;
            }
            if (discriminant == 0)
            {
                double s = -b / (2 * a);
                solve = "x = " + s.ToString("0.00");
                return;
            }
        }

        public double A
        {
            set { a = value; }
            get { return a; }

        }
        public double B
        {
            set { b = value; }
            get { return b; }

        }
        public double C
        {
            set { c = value; }
            get { return c; }

        }
        public string Solve
        {
            set { solve = value; }
            get { return solve; }

        }
    }
}
