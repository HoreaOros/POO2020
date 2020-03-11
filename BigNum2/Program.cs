using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNum2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BigNum b1 = new BigNum(4567890);
            BigNum b2 = new BigNum("34567894567845678945678678");
            BigNum b3 = new BigNum("1234567891234567891234567");
            Console.WriteLine($"{b2} + {b3} = {b2.Add(b3)}");

            // TODO - utilizarea altor operatii
            // Scadere, Inmultire, ridicare la putere etc. 
            // comparare
        }
    }
}
