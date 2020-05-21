using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Design pattern

            Singleton s1 = Singleton.getInstance();

            Singleton s2 = Singleton.getInstance();
        }
    }
}
