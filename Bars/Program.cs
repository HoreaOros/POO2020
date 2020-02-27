using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars
{
    class Program
    {
        static void Main(string[] args)
        {
            HorzBar h = new HorzBar(10);
            VertBar v = new VertBar(5);

            Frame f = new Frame(6, 8);

            Ladder ladd = new Ladder(3, 2);
        }
    }
}
