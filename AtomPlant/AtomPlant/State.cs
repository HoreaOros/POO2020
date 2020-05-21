using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomPlant
{
    // TODO: modificare implementare pentru a fi conforma cu .NET Framework Guidelines
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-publish-events-that-conform-to-net-framework-guidelines
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
