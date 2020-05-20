using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            // creare matrice 
            Matrice m1 = new Matrice(3, 4);
            Matrice m2 = new Matrice(4, 2);


            Matrice m4 = new Matrice(3, 3);
            Matrice m5 = new Matrice(3, 3);

         

            // initializare matrice
            m1.RandomInit(-20, 20);
            m2.RandomInit(-10, 10);
            m4.RandomInit(-10, 10);
            m5.RandomInit(-10, 10);


            // Operatii asupra matricilor
            Matrice m3 = m1 * m2;
            Matrice m7 = m4 + m5;
            Matrice m8 = m4 - m5;


            // afisare matrice
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
           



            Console.WriteLine(m4);
            Console.WriteLine(m5);
            Console.WriteLine(m7);
            Console.WriteLine(m8);



            if (m4 == m5)
            {
                Console.WriteLine("Matricile m4 si m5 sunt egale");
            }
            else
            {
                Console.WriteLine("Matricile m4 si m5 nu sunt egale");
            }





            Matrice m6 = new Matrice(10, 10);
            m6.RandomInit(-50, 50);


           // Matrice m7 = (Matrice)m6.Clone();

            if (m6 == m7)
            {
                Console.WriteLine("Matricile m6 si m7 sunt egale");
            }
            else
            {
                Console.WriteLine("Matricile m6 si m7 nu sunt egale");
            }

        }
    }
}
