using System;

namespace Curs7
{
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            C c = d;
            B b = c;
            A a = b;

            d.M();
            c.M();
            b.M();
            a.M();
        }
    }
}
