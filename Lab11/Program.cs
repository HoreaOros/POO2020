using System;
//using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray b1 = new BitArray(15);
            BitArray b2 = new BitArray(new byte[] {0xff, 0xf, 0x1f});
            for (int i = 0; i < b2.Length; i++)
            {
                int v = b2[i] ? 1 : 0;
                Console.Write($"{v} ");
            }

            Console.WriteLine();


            foreach (var item in b2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // aici testez setterul indexatorului
            b1[3] = true;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }
}
