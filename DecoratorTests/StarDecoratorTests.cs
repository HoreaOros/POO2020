using Microsoft.VisualStudio.TestTools.UnitTesting;
using DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Tests
{
    [TestClass()]
    public class StarDecoratorTests
    {
        [TestMethod()]
        public void GetValueTest()
        {
            // arrange
            IText tStar = new StarDecorator(new Text("Hello"));
            
            // act
            string actual = tStar.GetValue();
            string expected = "*** Hello ***";

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}