using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomPlant
{
    class Program
    {
        static void Main(string[] args)
        {
            // event publisher
            AtomPlant ap = new AtomPlant();

            // Subscriber #1
            State romania = new State("Romania", ap);

            // Subscriber #2
            State hungary = new State("Hungary", ap);

            // Publisher starts
            ap.Operate();


            Console.ReadKey();
        }
    }
}
