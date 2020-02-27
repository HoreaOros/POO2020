using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Am creat un obiect de tip Point");
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double DistanceTo(Point p2)
        {
            return Math.Sqrt(Math.Pow(x - p2.x, 2) + Math.Pow(y - p2.y, 2));
        }

        public void MoveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MoveBy(int dx, int dy)
        {
            this.x += dx;
            this.y += dy;
        }
    }
}
