using System;

namespace Lab4
{
    internal class Counter3
    {
        private Counter c1, c2, c3;
        public Counter3()
        {
            c1 = new Counter(); // contor pentru cifra unitatilor
            c2 = new Counter(); // contor pentru cifra zecilor
            c3 = new Counter(); // contor pentru cifra sutelor
        }

        public void Count()
        {
            c1.Count();
            if (c1.Value == 0)
            {
                c2.Count();
                if (c2.Value == 0)
                {
                    c3.Count();
                }
            }
        }
        public override string ToString()
        {
            return c3.ToString() + c2.ToString() + c1.ToString();
        }
    }
}