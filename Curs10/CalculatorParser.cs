using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Curs10
{
    class CalculatorParser
    {
        private string expr;
        private int op1, op2;
        private char operatie;
        private ICalculator opCalc;

        public ICalculator Operatie
        {
            get { return opCalc; }
            private set { opCalc = value; }
        }

        public int Op1
        {
            get
            {
                return op1;
            }
        }

        public int Op2
        {
            get { return op1; }
        }

        public CalculatorParser(string expr)
        {
            this.expr = expr;
            Parse();
        }
        private void Parse()
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
                    Operatie = new Add();
                    break;
                case '-':
                    Operatie = new Subtract();
                    break;
                case '*':
                    Operatie = new Multiply();
                    break;
                case '/':
                    Operatie = new Divide();
                    break;
                default:
                    break;
            }

            op2 = int.Parse(tokens[2]);
        }



        public void Parse(string exp)
        {
            this.expr = exp;
            Parse();
        }
    }
}
