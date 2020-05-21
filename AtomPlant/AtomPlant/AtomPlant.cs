using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomPlant
{
    class MEventArgs : EventArgs
    {
        private int temperature;
        public MEventArgs(int n)
        {
            this.temperature = n;
        }
        public int Temperature
        {
            get
            {
                return temperature;
            }
        }
    }
    class AtomPlant
    {
        public event EventHandler<MEventArgs> Explosion;
        public void Operate()
        {
            int n;
            Random r = new Random();
            while (true)
            {
                n = r.Next(10);
                Console.WriteLine("Core temperature is:{0}", n);
                
                if (n == 9 && Explosion != null)
                {
                    Console.WriteLine("BANG!!!");
                    Explosion(this, new MEventArgs(n));
                    break;
                }
            }
        }
    }
}
