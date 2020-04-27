using System;
namespace Lab7
{
    //TODO: adaugarea unei metode Perimetru
    internal abstract class FormaGeometrica: IGeometry
    {
        private Point position;
        private Guid guid;
        private static Random rnd = new Random();
        public FormaGeometrica()
        {
            Console.WriteLine("Am creat o forma Geometrica");
            
            position = new Point(rnd.Next(0, 100), rnd.Next(0, 100));
            guid = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"[{guid}, {position.ToString()}]";
        }


        abstract public double Aria();
        abstract public double Perimetru();

       
        public void f() { }
    }
}