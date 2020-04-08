using System;
namespace Curs7
{
    public class B: A
    {
        public override string M()
        {
            Console.WriteLine("B");
            return "B";
        }
    }
}