using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello world!");

            World w1 = new World("Terra");
            World w2 = new World("Marte");
            World w3 = new World("Betelgeuse");

            w1.SayHello();
            w2.SayHello();

            w2.SendMessage(w1, "Hello");
            w2.SendMessage(w1, "from Mars");
            w3.SendMessage(w1, "*&$&&^$&%!%");

            Console.WriteLine("Received messages:");
            foreach (var item in w1.Messages)
            {
                Console.WriteLine($"\t{item}");
            }
        }
    }
}
