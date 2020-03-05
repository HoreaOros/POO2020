using System;

namespace Lab2_2
{
    public class Util
    {
        public static int gcd(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
    }
}