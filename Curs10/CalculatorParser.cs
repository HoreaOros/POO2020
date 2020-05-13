using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs10
{
    class CalculatorParser
    {
        private ICalculator c;
        private string expr;
        public CalculatorParser(ICalculator c, string expr)
        {
            this.c = c;
            this.expr = expr;
        }
        public void Parse(out int op1, out int op2, out char operatie)
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

            op1 = int.Parse(tokens[0]); // poate sa genereze exceptie
            operatie = tokens[1][0];

            switch (operatie)
            {
                case '+':
                    c = new Add();
                    break;
                case '-':
                    c = new Subtract();
                    break;
                case '*':
                    c = new Multiply();
                    break;
                case '/':
                    c = new Divide();
                    break;
                default:
                    break;
            }


            op2 = int.Parse(tokens[2]);
        }
    }
}
