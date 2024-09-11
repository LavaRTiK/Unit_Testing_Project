using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math_OperationsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_OperationsLib.Tests
{
    [TestClass()]
    public class Math_OperationsTests
    {
        [TestMethod]
        public void SumTest()
        {
            Math_Operations calculator = new Math_Operations();
            Assert.AreEqual(calculator.Sum(3, 5), 8);
            Assert.AreEqual(calculator.Sum(-1, 1), 0);
            Assert.AreEqual(calculator.Sum(-1, -1), -2);
        }

        [TestMethod]
        public void SubtractTest()
        {
            Math_Operations calculator = new Math_Operations();
            Assert.AreEqual(calculator.Subtract(10, 5), 5);
            Assert.AreEqual(calculator.Subtract(0, 0), 0);
            Assert.AreEqual(calculator.Subtract(-1, -3), 2);
        }

        [TestMethod]
        public void DivideTest()
        {
            Math_Operations calculator = new Math_Operations();
            Assert.AreEqual(calculator.Divide(10, 2), 5);
            Assert.AreEqual(calculator.Divide(20, 2), 10);
            Assert.AreEqual(calculator.Divide(30, 2), 15);
        }

        [TestMethod]
        public void MultiplexTest()
        {
            Math_Operations calculator = new Math_Operations();
            Assert.AreEqual(calculator.Multiplex(2, 5), 10);
            Assert.AreEqual(calculator.Multiplex(10, 5), 50);
            Assert.AreEqual(calculator.Multiplex(2, 6), 12);
        }
    }
}