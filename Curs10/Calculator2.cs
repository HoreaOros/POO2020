using System;
namespace Curs10
{
    public class Calculator2
    {
        private int op1, op2; // operanzii expresiei
        private char operatie;
        public int Value { get; private set; }

        public ICalculator c;


        //TODO
        // eliminam constructorul care primeste string iar parsingul epxresiei se va face in afara
        // clasei Calcualtor2
        // ramane doar construtorul cu 3 parametri --> public Calculator2(int op1, int op2, ICalculator c)
        
            
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="expr">1    + 2, 3 * 4</param>
        public Calculator2(string expr)
        {
            char[] sep = {' '};
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


            op2 = int.Parse(tokens[2]); // poate sa genereze exceptie
        }

        public Calculator2(int op1, int op2, ICalculator c)
        {
            this.op1 = op1;
            this.op2 = op2;
            this.c = c;
        }
        public void Evaluate()
        {
            Value = c.Operation(op1, op2);
        }
    }
}