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
            AtomPlant ap = new AtomPlant();
            State romania = new State("Romania", ap);
            State hungary = new State("Hungary", ap);
            ap.Operate();
        }
    }
}
