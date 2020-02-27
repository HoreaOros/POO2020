using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Drawing;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //Console.WriteLine(rnd.Next(0, 10));

            //Stack<int> st = new Stack<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    st.Push(i);
            //}
            //while (st.Count > 0)
            //{
            //    Console.WriteLine(st.Pop());
            //}

            //Process.Start("notepad");



            //Process[] procs = Process.GetProcesses();
            //foreach (var item in procs)
            //{
            //    Console.WriteLine($"{item.ProcessName}");
            //}


            Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);


            Console.WriteLine(p1.DistanceToOrigin());
            Console.WriteLine(p2.DistanceToOrigin());

            Console.WriteLine(p1.DistanceTo(p2));

            p1.MoveTo(2, 3);
            p2.MoveBy(1, 5);


            // TODO
            //p1.Rotate(30);
        }
    }
}
