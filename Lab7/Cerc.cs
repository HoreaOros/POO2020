using System;
namespace Lab7
{
    //TODO: implementarea clasei cerc dupa modelul dreptunghiului
    // pentru cerc trebuie sa pastreaz centrul cercului si raza
    /// <summary>
    /// Clasa cerc
    /// </summary>
    internal class Cerc : FormaGeometrica
    {
        private double radius;
        private static Random rnd = new Random();
        public Cerc()
        {
            Console.WriteLine("Am creat un cerc");
            this.radius = rnd.Next(10);
        }
        public Cerc(double radius)
        {
            Console.WriteLine("Am creat un cerc");
            this.radius = radius;
        }
        public override double Aria()
        {
            return Math.Pow(radius,2) * Math.PI;
        }
        public override double Perimetru()
        {
            return 2 * radius * Math.PI ;
        }
    }
}