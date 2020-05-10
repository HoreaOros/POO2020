using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter();


            for (int i = 0; i < 10; i++)
            {
                c1.Count();
            }
            Console.WriteLine(c1);
        }
    }
}
