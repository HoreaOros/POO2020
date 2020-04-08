using System;
namespace Curs7
{
    public class C: B
    {
        new public virtual string M()
        {
            Console.WriteLine("B");
            return "C";
        }
    }
}