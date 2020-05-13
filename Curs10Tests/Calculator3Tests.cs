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
            string expresie = "1 + 2";
            CalculatorParser cp = new CalculatorParser(expresie);

            Operatie operatie;

            operatie = Operatii.Add;

            Calculator3 c3 = new Calculator3(cp.Op1, cp.Op2, operatie);


            // act 
            c3.Evaluate();

            int expected = 3;
            int actual = c3.Value;


            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}