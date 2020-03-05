using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r = new Rational(5);
            Rational r1 = new Rational(1, 2);
            Rational r2 = new Rational(3, 4);



            Rational r3 = r1.Add(r2);
            Console.WriteLine($"{r1} + {r2} = {r3}");

            Rational r4 = r1.Subtract(r2);
            Console.WriteLine($"{r1} - {r2} = {r4}");


            Rational r5 = r1.Multiply(r2);
            Console.WriteLine($"{r1} * {r2} = {r5}");

          
            Rational r6 = r1.Divide(r2);
            Console.WriteLine($"{r1} / {r2} = {r6}");

            int k = 3;
            Rational r7 = r1.Power(k);
            Console.WriteLine($"{r1} ^ {k} = {r7}");

        }
    }
}
