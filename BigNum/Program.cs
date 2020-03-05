using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNum
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: implement BigInt
            BigInt b1 = new BigInt(1234567);
            BigInt b2 = new BigInt("23456789234567893456783456789");

            BigInt b3 = b1.Add(b2);
            Console.WriteLine($"{b1} + {b2} = {b3}");
            
            // scadere
            // inmultire
            // radical
            // impartire 
            // mod (restul impartirii)

            // etc.


        }
    }
}
