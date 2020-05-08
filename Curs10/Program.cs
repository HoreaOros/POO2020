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

            PerformOperations();
            
        }

        private static void PerformOperations()
        {
            string line;
            bool done = false;
            string expr;
            while (!done)
            {
                printMenu();
                Console.WriteLine("Type option 1 or 2: ");
                line = Console.ReadLine();
                switch (line)
                {
                    case "1":
                        expr = Console.ReadLine();
                        Parse(expr);
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
                        
        private static void Parse(string expr)
        {
            try
            {
                char[] sep = { ' ' };
                string[] tokens = expr.Split(sep, 3, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length != 3)
                {
                    throw new ArgumentException();
                }
                if (tokens[1].Length != 1)
                {
                    throw new ArgumentException();
                }

                try
                {
                    var op1 = int.Parse(tokens[0]);
                    var op2 = int.Parse(tokens[2]);
                    char operatie = tokens[1][0];
                    ICalculator c;

                    switch (operatie)
                    {
                        case '+':
                            c = new Add();
                            GetOperation(op1, op2, c);
                            break;

                        case '-':
                            c = new Subtract();
                            GetOperation(op1, op2, c);
                            break;
                        case '*':
                            c = new Multiply();
                            GetOperation(op1, op2, c);
                            break;
                        case '/':
                            c = new Divide();
                            GetOperation(op1, op2, c);
                            break;
                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Operanzi invalizi");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Expresia introdusa nu este corecta");
            }
        }

        private static void GetOperation(int op1, int op2, ICalculator c)
        {
            Calculator2 calc = new Calculator2(op1, op2, c);
            calc.Evaluate();
            Console.WriteLine(calc.Value);
        }

        private static void printMenu()
        {
            Console.WriteLine("Optiuni:");
            Console.WriteLine("1. introduceti o expresie aritmetica in care atomii lexicali sa fie separati prin spatiu");
            Console.WriteLine("2. Exit");
        }
    }
}

                

                
                




