using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;

namespace MathLibraryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FibonacciTest()
        {
            Assert.AreEqual(0, NumberSequence.Fibonacci(0));
            Assert.AreEqual(1, NumberSequence.Fibonacci(1));
            Assert.AreEqual(1, NumberSequence.Fibonacci(2));
            Assert.AreEqual(5, NumberSequence.Fibonacci(5));
            Assert.AreEqual(55, NumberSequence.Fibonacci(10));
            Assert.AreEqual(6765, NumberSequence.Fibonacci(20));
        }

        [TestMethod]
        public void CatalanTest()
        {
            Assert.AreEqual(1, NumberSequence.Catalan(0));
            Assert.AreEqual(1, NumberSequence.Catalan(1));
            Assert.AreEqual(2, NumberSequence.Catalan(2));
            Assert.AreEqual(42, NumberSequence.Catalan(5));
            Assert.AreEqual(16796, NumberSequence.Catalan(10));
            Assert.AreEqual(6564120420, NumberSequence.Catalan(20));
        }

        [TestMethod]
        public void BellTest()
        {
            Assert.AreEqual(1, NumberSequence.Bell(0));
            Assert.AreEqual(1, NumberSequence.Bell(1));
            Assert.AreEqual(2, NumberSequence.Bell(2));
            Assert.AreEqual(52, NumberSequence.Bell(5));
            Assert.AreEqual(11597, NumberSequence.Bell(10));
            Assert.AreEqual(5172415823572, NumberSequence.Bell(20));
        }
    }
}
