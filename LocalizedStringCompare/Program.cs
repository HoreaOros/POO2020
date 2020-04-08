using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LocalizedStringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Ștefan", "Elena", "Sara", "Maria", "Arena", "Bella", "Ănt", "Țăndărică", "Tudor", };

            Array.Sort(names, new MyComparer());
            StreamWriter sw = new StreamWriter("output.txt");
            foreach (var item in names)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }
    }
}
