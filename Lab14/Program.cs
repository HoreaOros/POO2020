using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] {54, 71, 1,  9, 11, 18};


            Predicate<int> match = IsPrime;

            // determinam daca in lista este un numar prim
            if(Array.Exists(data, match))
                Console.WriteLine("In lista am cel putin un numar prim");

            // determinam daca in lista este un numar par
            match = IsEven;
            if(Array.Exists(data, match))
                Console.WriteLine("In lista am cel putin un numar par");
            //Array.Exists(data, elem => elem % 2 == 0);

            // determinam daca in lista este un numar format din 3 cifre
            match = Is3Digit;
            if(Array.Exists(data, match))
                Console.WriteLine("In lista am cel putin un numar format din 3 cifre");


            Console.WriteLine($"Primul numar prim din lista este: {Array.Find(data, IsPrime)}");
            Console.WriteLine($"Ultimul numar prim din lista este: {Array.FindLast(data, IsPrime)}");


            Console.WriteLine("Toate numerele prime din lista sunt:");
            int[] result = Array.FindAll(data, IsPrime);
            foreach (var item in result)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();


            //Array.Sort(data);
            //foreach (var item in data)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            // 54, 71, 1,  9, 11, 18
            // sortare dupa suma cifrelor: 1 11 71 9 18 54
            
            IComparer<int> digitSum = new DigitSumComparer();
            Array.Sort(data, digitSum);

            foreach (var item in data)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static bool Is3Digit(int num)
        {
            int digitCount = 0;
            while (num != 0)
            {
                digitCount++;
                num /= 10;
            }
            return digitCount == 3;
        }

        private static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        private static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }
            if (num % 2 == 0)
            {
                return false;
            }
            for (int d = 3; d * d <= num; d += 2)
            {
                if (num % d == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
