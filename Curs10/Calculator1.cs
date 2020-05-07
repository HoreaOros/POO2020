using System;
namespace Curs10
{
    public class Calculator1
    {
        private int op1, op2; // operanzii expresiei
        private char operatie;
        public int Value { get; private set; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="expr">1    + 2, 3 * 4</param>
        public Calculator1(string expr)
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
            op2 = int.Parse(tokens[2]); // poate sa genereze exceptie
        }

        /// <summary>
        /// OPC - open closed principle - aici nu e indeplinit
        /// </summary>
        public void Evaluate()
        {
            switch (operatie)
            {
                case '+':
                    Value = op1 + op2;
                    break;
                case '-':
                    Value = op1 - op2;
                    break;
                case '*':
                    Value = op1 * op2;
                    break;
                case '/':
                    Value = op1 / op2;
                    break;
                default:
                    break;
            }
        }
    }
}