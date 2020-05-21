using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Curs12
{
    delegate void MyDelegate(string s);
    class Program
    {
        static void f1(string s)
        {
            Console.WriteLine(s);
        }
        static void f2(string s)
        {
            Console.WriteLine("(" + s + ")");
        }
        static void Main(string[] args)
        {
            #region Delegati
            //MyDelegate d = new MyDelegate(f1);


            //d += f2;

            //d("Hello");

            //Delegate[] list = d.GetInvocationList();
            //foreach (var item in list)
            //{
            //    ((MyDelegate)item)("Hello");
            //}
            #endregion


            Timer t = new Timer(2000);
            t.Elapsed += T_Elapsed;
            t.Enabled = true;
            t.AutoReset = true;

            Console.ReadLine();

        }

        private static void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(e.SignalTime);
        }
    }
}
