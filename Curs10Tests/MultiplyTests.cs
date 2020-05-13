using Microsoft.VisualStudio.TestTools.UnitTesting;
using Curs10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs10.Tests
{
    [TestClass()]
    public class MultiplyTests
    {
        [TestMethod()]
        public void OperationTest()
        {
            // arrange
            Multiply m = new Multiply();



            // act 
            int actual = m.Operation(3, 4);
            int expected = 12;
            // assert

            Assert.AreEqual(expected, actual);
        }
    }
}