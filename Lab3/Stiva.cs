using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stiva st = new Stiva();


            try
            {
                Console.WriteLine("Elementul din varful stivei este:{0}", st.Peek);
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("capacitatea stivei este: {0}", st.Capacity);

            for (int i = 0; i < 10; i++)
            {
                st.Push(i);
            }


            while (!st.Empty())
            {
                Console.WriteLine(st.Pop());
            }


            Stiva st2 = new Stiva(128);
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                st2.Push(rnd.Next(100));
            }
        }
    }
}