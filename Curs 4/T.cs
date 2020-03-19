using System;

namespace Curs_4
{
    public class T
    {
        private int id;
        private static int count = 0;

        public static int Objects 
        { 
            get
            {
                return count;
            }
        }

        public int ID 
        { 
            get
            {
                return id;
            }
            set
            {
                if (value >= 0)
                    id = value;
                else
                    throw new ArgumentException("valoarea id-ului nu poate fi negativa");
            }
        }

        public T(int id)
        {
            this.id = id;
            ++count;
        }
        public T(): this(0)
        {
            
        }
        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public static void SayHello(string name)
        {
            SayHello();
            Console.WriteLine(name);
        }


        public void SayGoodBye()
        {
            Console.WriteLine("GoodBye!");
        }

        public override string ToString()
        {
            return "T: " + id;
        }
    }
}