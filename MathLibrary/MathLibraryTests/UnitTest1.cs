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
            Assert.AreEqual(1u, NumberSequence.Catalan(0));
            Assert.AreEqual(1u, NumberSequence.Catalan(1));
            Assert.AreEqual(2u, NumberSequence.Catalan(2));
            Assert.AreEqual(42u, NumberSequence.Catalan(5));
            Assert.AreEqual(16796u, NumberSequence.Catalan(10));
        }

        [TestMethod]
        public void Factorial()
        {
            Assert.AreEqual(1u, NumberSequence.Factorial(0));
            Assert.AreEqual(1u, NumberSequence.Factorial(1));
            Assert.AreEqual(2u, NumberSequence.Factorial(2));
            Assert.AreEqual(120u, NumberSequence.Factorial(5));
            Assert.AreEqual(3628800u, NumberSequence.Factorial(10));
            Assert.AreEqual(2432902008176640000u, NumberSequence.Factorial(20));
        }

        [TestMethod]
        public void PadovanTest()
        {
            Assert.AreEqual(1, NumberSequence.Padovan(0));
            Assert.AreEqual(0, NumberSequence.Padovan(1));
            Assert.AreEqual(0, NumberSequence.Padovan(2));
            Assert.AreEqual(1, NumberSequence.Padovan(5));
            Assert.AreEqual(3, NumberSequence.Padovan(10));
            Assert.AreEqual(49, NumberSequence.Padovan(20));
        }
    }
}
