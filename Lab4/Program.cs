using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter();

            //while (true)
            //{
            //    c.Count();
            //    Console.WriteLine(c);
            //}

            Counter3 c3 = new Counter3();

            while (true)
            {
                c3.Count();
                //System.Threading.Thread.Sleep(1000); // 1000 milisecunde
                Console.WriteLine(c3);
            }


            // TODO
            // actualizarea proramului driver prin introducerea clasei Timer 
            // contorul sa fie "actionat" la fiecare secunda. 


            // TODO
            // sa se creeeze un contor generalizat
            // CounterN = new CounterN(7);



        }
    }
}
