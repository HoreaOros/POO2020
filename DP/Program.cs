using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Text t = new Text("Hello");
            Console.WriteLine(t.GetValue());

            IText d1 = new StarDecorator(t);
            Console.WriteLine(d1.GetValue());

            IText d2 = new ParantheseDecorator(d1);
            Console.WriteLine(d2.GetValue());

            IText d3 = new StarDecorator(new ParantheseDecorator(new StarDecorator(new Text("42"))));
            Console.WriteLine(d3.GetValue());
        }
    }
}
