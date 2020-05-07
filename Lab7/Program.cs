using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Forme geometrice

            FormaGeometrica fg1 = new Dreptunghi();
            FormaGeometrica fg2 = new Cerc();

            f(new Dreptunghi());
            f(new Cerc());



            List<FormaGeometrica> list = new List<FormaGeometrica>();
            int v;
            for (int i = 0; i < 100; i++)
            {
                v = Util.RND.Next(2);
                switch (v)
                {
                    case 0:
                        list.Add(new Dreptunghi());
                        break;
                    case 1:
                        list.Add(new Cerc());
                        break;
                    default:
                        break;
                }
            }


            foreach (var fg in list)
            {
                try
                {
                    Console.WriteLine(fg.Aria());
                }
                catch (NotImplementedException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadKey();
        }
        static void f(FormaGeometrica fg)
        {
            try
            {
                Console.WriteLine(fg.Aria()); 
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        
    }
}
