using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomPlant
{
    class State
    {
        private string name;
        AtomPlant ap;
        public State(string s, AtomPlant ap)
        {
            name = s;
            this.ap = ap;
            this.ap.Explosion += new EventHandler<MEventArgs>(ap_Explosion);
        }

        void ap_Explosion(object sender, MEventArgs e)
        {
            Console.WriteLine("{0} received a notification of the explosion", name);
            Console.WriteLine("Core temperature: {0}", e.Temperature);
        }
        public string Name
        {
            get
            {   
                return name;
            }
        }
    }
}
