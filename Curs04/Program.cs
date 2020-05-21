using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            T.SayHello();
            T.SayHello("World");


            T t = new T(19);
            t.SayGoodBye();



            Console.WriteLine(t);


            Console.WriteLine("Number of objects: {0}", T.Objects);

            T t2 = new T(20);
            Console.WriteLine("Number of objects: {0}", T.Objects);



            // transmitere de parametri prin valoare

            int n = 42; // valoare
            T t3 = new T(22); // referinta


            Console.WriteLine($"Val by val, Before: {n}");
            ValByVal(n);
            Console.WriteLine($"Val by val, After: {n}");


            Console.WriteLine($"Ref by val, Before: {t3}");
            RefByVal(t3);
            Console.WriteLine($"Ref by val, After: {t3}");




            // transmitere de parametri prin referinta

            Console.WriteLine($"Val by ref, Before: {n}");
            ValByRef(ref n);
            Console.WriteLine($"Val by ref, After: {n}");



            Console.WriteLine($"Ref by ref, Before: {t3}");
            RefByRef(ref t3);
            Console.WriteLine($"Ref by ref, After: {t3}");


        }

        private static void RefByRef(ref T t)
        {
            t = new T(66);
        }

        private static void ValByRef(ref int n)
        {
            n++;
        }

        private static void RefByVal(T t)
        {
            // aici atat t cat si t3 se refera la obiectul cu id 22
            //t = new T(100);
            // aici t se se refera la noul obiect cu idul 100 iar t3 (din main) se refera in continuare la T(22)


            t.ID = 23; // modific obiectul referit
        }

        private static void ValByVal(int n)
        {
            n++;
        }
    }
}
