using Calculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestEquals()
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(1, 2);
            Assert.AreEqual(true, Operations.IsEqual(a, b));
        }

        [Test]
        public void TestAdd()
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(2, 6);
            Complex expected = new Complex(3, 8);
            Assert.AreEqual(true, Operations.IsEqual(expected, Operations.Add(a, b)));
        }

        [Test]
        public void TestSub()
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(2, 6);
            Complex expected = new Complex(-1, -4);
            Assert.AreEqual(true, Operations.IsEqual(expected, Operations.Sub(a, b)));
        }

        [Test]
        public void TestMul()
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(2, 6);
            Complex expected = new Complex(-10, 10);
            Assert.AreEqual(true, Operations.IsEqual(expected, Operations.Mul(a, b)));
        }

        [Test]
        public void TestDiv()
        {
            Complex a = new Complex(1, 0);
            Complex b = new Complex(1, 1);
            Complex expected = new Complex(0.5, -0.5);
            Assert.AreEqual(true, Operations.IsEqual(expected, Operations.Div(a, b)));
        }
    }
}
