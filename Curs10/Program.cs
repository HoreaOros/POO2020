using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs10
{
    class Program
    {
        static void Main(string[] args)
        {
            /// cream un calculator
            /// operatii aritmetice asupra a doi operanzi
            /// inputul va fi: 2 operanzi si operatorul


            string line;
            bool done = false;
            string expr;
            while (!done)
            {
                printMenu();
                line = Console.ReadLine();
                switch (line)
                {
                    case "1":
                        expr = Console.ReadLine();
                        try
                        {
                            // TODO CalculatorParser trebuie transformat intr-un singleton
                            CalculatorParser cp = new CalculatorParser(expr);
                            Calculator2 c = new Calculator2(cp.Op1, cp.Op2, cp.Operatie);
                            c.Evaluate();
                            Console.WriteLine(c.Value);
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Expresia introdusa nu este corecta");
                        }
                        
                        break;
                    case "2":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Optiune invalida");
                        break;
                }
            }
        }

        private static void printMenu()
        {
            Console.WriteLine("Optiuni:");
            Console.WriteLine("1. introduceti o expresie aritmetica in care atomii lexicali sa fie separati prin spatiu");
            Console.WriteLine("2. Exit");
        }
    }
}
