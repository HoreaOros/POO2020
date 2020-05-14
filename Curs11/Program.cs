using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Curs11
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStackOfInt st = new MyStackOfInt();

            st.Push(1);
            st.Push(2);
            st.Push(3);


            Console.WriteLine("Elementeul din varful stivei este: {0}", st.Peek());

            while (!st.Empty)
            {
                Console.WriteLine(st.Pop());
            }


            MyStackOfString stStr = new MyStackOfString();

            stStr.Push("Hello");
            stStr.Push("World");



        }
    }
}
