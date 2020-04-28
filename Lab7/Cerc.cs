using System;
namespace Lab7
{
    /// <summary>
    /// Clasa cerc
    /// </summary>
    internal class Cerc : FormaGeometrica
    {
        private int raza;
        private Point centru;

        public Cerc()
        {
            Console.WriteLine("Am creat un cerc");
            raza = Util.RND.Next(1, 20);
            centru = Point.randomPoint();
        }

        public override double Aria()
        {
            return Math.PI * Math.Pow(raza, 2);
        }

        public override double Perimetru()
        {
            return 2 * Math.PI * raza;
        }

        public override string ToString()
        {
            return base.ToString() + $", {raza}";
        }
    }
}