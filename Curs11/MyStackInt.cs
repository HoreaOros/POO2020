using System;
using System.Runtime.CompilerServices;

namespace Curs11
{
    public class MyStackOfInt
    {
        private int[] data;
        private int count = 0;
        public MyStackOfInt()
        {
            data = new int[10];
        }

        public bool Empty
        {
            get
            {
                return count == 0;
            }
        }

        public void Push(int v)
        {
            if (count < data.Length)
            {
                data[count++] = v;
            }
            else
                throw new StackFullException("Stiva este plina");
            
        }

        public int Pop()
        {
            if (!this.Empty)
            {
                count--;
                return data[count];
            }
            else
                throw new StackEmptyException("Stiva este goala");
        }
        public int Peek()
        {
            if (!this.Empty)
            {
                return data[count - 1];
            }
            else
                throw new StackEmptyException("Stiva este goala");
        }
    }
}