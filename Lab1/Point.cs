using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Point
    {
        private double x, y;


        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

            Console.WriteLine("Am creat un obiect de tip Point({0}, {1})", x, y);
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public double DistanceTo(Point p2)
        {
            return Math.Sqrt(Math.Pow(x - p2.x, 2) + Math.Pow(y - p2.y, 2));
        }

        public void Print()
        {
            Console.WriteLine($"({x}, {y})");
        }

        public void MoveTo(double x, double y)
        {
            Console.WriteLine("Point moved from ({0}, {1})  to ({2}, {3})", 
                this.x, this.y, x, y);
            this.x = x;
            this.y = y;
        }


        public void MoveBy(double dx, double dy)
        {
            Console.Write("Point ({0}, {1}) moved by  ({2}, {3}). ",
                this.x, this.y, dx, dy);
            this.x += dx;
            this.y += dy;
            Console.WriteLine("New location ({0}, {1})", this.x, this.y);
        }
    }
}
