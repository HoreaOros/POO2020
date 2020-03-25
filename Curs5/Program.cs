using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tablouri

            int[] vec; // aici declar doar o variabila de tip tablou care se va putea referi la un vector

            vec = new int[10]; // aici aloc memorie pentru un tablou de 10 elemente si asociez referinta vec cu zona tabloul alocat
            // elementele vectorului sunt initializate la 0; 



            // definesc o matrice de caractere cu 4 linii 5 coloane si o initializez explicit la definitie
            char[,] matrice = new char[4, 5]
                {
                    {'a', 'b', '0', '$', '.' },
                    {'u', 'v', '3', '#', ',' },
                    {'r', 'c', '7', '^', '/' },
                    {'a', 'e', '9', '!', '?' },
                }; 

            long[,,] cub = new long[2, 3, 4]; // definesc un "cub" cu 2x3x4 = 24 de elemente



            //argumente in linia de comanda
            // avem acces la ele prin parametrul "args" pe care il primeste metoda Main
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }




            // tablourile sunt indexate de la zero
            int sum = 0;
            for (int i = 0; i < vec.Length; i++) // numarul de elemente din vector il obtinem cu proprietatea Length
            {
                sum += vec[i];
            }


            // o secventa cu vectori de frecventa
            int[] frecventa = new int[26];
            for (int i = 0; i < matrice.GetLength(0); i++) // GetLength(0) ne spune cate linii are matricea
            {
                for (int j = 0; j < matrice.GetLength(1); j++) // GetLength(1) ne spune cate coloane are matricea
                {
                    if(char.IsLower(matrice[i,j]))
                        frecventa[matrice[i, j] - 'a']++;
                }
            }

            for (int i = 0; i < frecventa.Length; i++)
            {
                if (frecventa[i] >0)
                {
                    Console.WriteLine($"{(char)('a' + i)} - {frecventa[i]}");
                }
            }


            // dimensiunea/dimensiunile unui tablou pot fi stabilite la executie
            Random rnd = new Random();
            int[] randomSizeArray = new int[rnd.Next(10)];

            
            for (int i = 0; i < randomSizeArray.Length; i++)
            {
                randomSizeArray[i] =rnd.Next(100); // initializez valorile din vector cu valori aleatorii
            }
            printArray(randomSizeArray);


            ModifyArray(randomSizeArray);

            printArray(randomSizeArray);



            printArrayInfo(vec);
            printArrayInfo(matrice);


            // Sortam vectorul
            Array.Sort(randomSizeArray);

            // TODO
            // Cum sortam dupa un alt criteriu???





            // Metoda generica pentru a crea un vector
            int[] creat1 = CreateArray<int>(42);
            char[] creat2 = CreateArray<char>(10);
            string[] creat3 = CreateArray<string>(19);


            // TODO
            // studiati clasa System.Array 
        }
        /// <summary>
        /// Metoda generica pentru crearea unui vector de numere intregi si intoarcem referinta la el
        /// </summary>
        /// <param name="size">Numarul de elemente ale vectorului creat</param>
        /// <returns></returns>
        private static T[] CreateArray<T>(int size)
        {
            return new T[size];
        }

        /// <summary>
        /// Afiseaza informatii despre orice tablou
        /// </summary>
        /// <param name="array">Tabloul despre care obtinem informatii</param>
        private static void printArrayInfo(Array array)
        {
            Console.WriteLine($"Rank: {array.Rank}");
            for (int i = 0; i < array.Rank; i++)
            {
                Console.WriteLine($"{array.GetLength(i)} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Mareste cu 1 valoarea fiecarui element al vectorului
        /// </summary>
        /// <param name="array">Vectorul ale carui elemente sunt modificate</param>
        private static void ModifyArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++; // modificarea va avea efect asupra vectorului din metoda Main care a fost transmis ca si parametru
            }
        }

        /// <summary>
        /// Afiseaza elementele unui vector de numere intregi pe o singura linie
        /// </summary>
        /// <param name="array">Vectorul care se afiseaza</param>
        private static void printArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
