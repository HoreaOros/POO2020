using System;
namespace Lab7
{
    public class Dreptunghi : FormaGeometrica
    {
        private int lungime, latime;
         
        public Dreptunghi()
        {
            Console.WriteLine("Am creat un dreptunghi");
            lungime = Util.RND.Next(1, 50);
            latime = Util.RND.Next(1, 50);
        }
        public override double Aria()
        {
            return lungime * latime;
        }
        public override double Perimetru()
        {
            return 2 * (lungime + latime);
        }
        public override string ToString()
        {
            return base.ToString() + $", ({lungime}, {latime})";
        }
    }
}