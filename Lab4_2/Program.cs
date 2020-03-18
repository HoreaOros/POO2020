using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            //TimeSpan ts = new TimeSpan(1, 5, 4);

            
            
            //Console.WriteLine(dt);
            //Console.WriteLine(ts);

            DT d = new DT(); // ce trebuie sa faca constructorul fara parametri??? i18n

            Console.WriteLine(d);

            DT d2 = new DT(2020, 3, 18, 0, 0, 0);

            Console.WriteLine($"Anul: {d2.Year}");


            // operatii pentru DT
            // diferenta dintre doua date calendaristice
            // getters(/setters) pentru componentele lui DT

            d2.AddYears(10);
            Console.WriteLine($"Anul: {d2}");

            // d2.AddMonths(20);// trebuie gasit un raspuns adecvat la modul in care trebuie calculat rezultatul.

            // TODO
            // adaugati operatii cu tipul de date DT (similare cu cele pe care le are DateTime)

            // TODO
            // Realizati o implementare proprie pentru TimeSpan (TS) - modelati obiectual conceptul de interval de timp
            // veti folosi ca si model tipul TimeSpan.



        }
    }
}
