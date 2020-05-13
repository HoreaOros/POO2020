using Microsoft.VisualStudio.TestTools.UnitTesting;
using Curs10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Curs10.Tests
{
    [TestClass()]
    public class Calculator3Tests
    {


        [TestMethod()]
        public void EvaluateTest()
        {
            // arrange
            string expresie = "1 ? 2";
            CalculatorParser cp = new CalculatorParser(expresie);

            Operatie operatie = null;


            /// instructiune switch care foloseste type pattern
            /// valabil doar in C# v7.0 sau mai mare.
            switch (cp.Operatie)
            {
                case Add op:
                    operatie = Operatii.Add;
                    break;
                case Subtract op:
                    operatie = Operatii.Subtract;
                    break;
                case Multiply op:
                    operatie = Operatii.Multiply;
                    break;
                case Divide op:
                    operatie = Operatii.Divide;
                    break;
                default:
                    break;
            }

            if (operatie == null)
            {
                return;
            }
            Calculator3 c3 = new Calculator3(cp.Op1, cp.Op2, operatie);


            // act 
            c3.Evaluate();

            int expected = -1;
            int actual = c3.Value;


            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}