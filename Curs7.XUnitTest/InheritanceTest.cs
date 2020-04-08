using System;
using Xunit;

namespace Curs7.XUnitTest
{
    public class InheritanceTest
    {
        [Fact]
        public void ReferenceEqualityTest()
        {
            D d = new D();
            C c = d;
            B b = c;
            A a = b;
            Assert.Same(c, d);
            Assert.Same(b, d);
            Assert.Same(a, d);
            Assert.Same(a, b);
        }
        [Fact]
        public void ReturnValueTest()
        {
            D d = new D();
            C c = d;
            B b = c;
            A a = b;
            var result = d.M() + c.M() + b.M() + a.M();
            Assert.Equal("DDBB", result);
        }
    }
}
