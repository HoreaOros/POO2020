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