using System;
namespace Lab7
{
    internal class Dreptunghi : FormaGeometrica
    {
        private int lungime, latime;
        
        private static Random rnd = new Random(); 
        public Dreptunghi()
        {
            Console.WriteLine("Am creat un dreptunghi");
            lungime = rnd.Next(1, 50);
            latime = rnd.Next(1, 50);
        }
        public override double Aria()
        {
            return lungime * latime;
        }
        public override string ToString()
        {
            return base.ToString() + $", ({lungime}, {latime})";
        }
    }
}