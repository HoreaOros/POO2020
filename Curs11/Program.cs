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
            Console.WriteLine("MyStack of int demo");
            MyStack<int> st = new MyStack<int>();

            st.Push(1);
            st.Push(2);
            st.Push(3);

            



            Console.WriteLine("Elementul din varful stivei este: {0}", st.Peek());


            DumpStack(st);



            Console.WriteLine("MyStack of string demo");
            MyStack<string> stStr = new MyStack<string>();

            stStr.Push("Hello");
            stStr.Push("World");


            DumpStack(stStr);



            Console.WriteLine("SuperStack of int demo");

            SuperStack<int> ss = new SuperStack<int>();

            ss.Push(4);
            ss.Push(3);
            ss.Push(2);
            ss.Push(1);


            Console.WriteLine(ss.Peek());

            DumpStack(ss);

        }

        public static void DumpStack<T>(IStack<T> st)
        {
            while (!st.Empty)
            {
                Console.WriteLine(st.Pop());
            }
        }
    }
}
