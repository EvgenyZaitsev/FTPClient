using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_1
{
    public class Point
    {
        private double x;
        private double y;

        public Point()
        {
            x = 0.0;
            y = 0.0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            set { x = value; }
            get { return x; }
        }
        public double Y
        {
            set { y = value; }
            get { return y; }
        }
        public override string ToString()
        {
            string s;
            s = "(" + x.ToString("0.00") + ", " + x.ToString("0.00") + ")";
            return s;
        }
        public bool Equals(Point p)
        {
            if ((object)p == null)
            {
                return false;
            }
            
            return (x == p.x) && (y == p.y);
        }
        public override bool Equals(object obj)
        {
            // If parameter cannot be cast to ThreeDPoint return false:
            Point p = obj as Point;
            if ((object)p == null)
            {
                return false;
            }
            return (x == p.x) && (y == p.y);
        }
    }
}
