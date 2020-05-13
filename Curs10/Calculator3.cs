using System;
namespace Curs10
{
    public class Calculator3
    {
        private int op1, op2; // operanzii expresiei
        private char operatie;
        public int Value { get; private set; }
        private Operatie op;

        //TODO
        // eliminam constructorul care primeste string iar parsingul epxresiei se va face in afara
        // clasei Calcualtor2
        // ramane doar construtorul cu 3 parametri --> public Calculator2(int op1, int op2, ICalculator c)


        public Calculator3(int op1, int op2, Operatie c)
        {
            this.op1 = op1;
            this.op2 = op2;
            this.op = c;
        }
        public void Evaluate()
        {
            Value = op(op1, op2);
        }
    }
}