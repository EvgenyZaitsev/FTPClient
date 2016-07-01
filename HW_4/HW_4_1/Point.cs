using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_1
{
    public class Point
    {
        public Point()
        {
            this.X = 0.0;
            this.Y = 0.0;
        }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double X { set; get; }
        public double Y { set; get; }
        public override string ToString()
        {
            string s;
            s = "(" + this.X.ToString("0.00") + ", " + this.Y.ToString("0.00") + ")";
            return s;
        }
        public bool Equals(Point p)
        {
            if ((object)p == null)
            {
                return false;
            }
            
            return (this.X == p.X) && (this.Y == p.Y);
        }
        public override bool Equals(object obj)
        {
            Point p = obj as Point;
            if ((object)p == null)
            {
                return false;
            }
            return (this.X == p.X) && (this.Y == p.Y);
        }
    }
}
