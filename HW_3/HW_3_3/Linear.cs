using System;

namespace HW_3_3
{
    public class Linear
    {
        private double a;
        private double b;
        private string solve;

        public Linear (double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void FindSolution()
        {
            if (a != 0)
            {
                solve = "x = ";
                solve += (-b / a).ToString("0.00");
                return;
            }
            if (a == 0 && b == 0)
            {
                solve = "x may be any number";
                return;
            }
            if (a == 0 && b != 0)
            {
                solve = "there is no solutions";
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
        public string Solve
        {
            set { solve = value; }
            get { return solve; }

        }
    }
}
