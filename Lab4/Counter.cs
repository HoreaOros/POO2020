using System;

namespace Lab4
{
    internal class Counter
    {
        private int n;
        public Counter()
        {
            n = 0;
        }

        public int Value 
        {
            get
            {
                return n;
            } 
        }

        public void Count()
        {
            n++;
            if (n == 10)
            {
                n = 0;
            }
        }
        public override string ToString()
        {
            return "[" + n.ToString() + "]";
        }
    }
}