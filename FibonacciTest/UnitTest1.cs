using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fibonacci;

namespace FibonacciTest
{
    /*
     * Needs to be set to .NET 5.0 for yml to run correctly
     */
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFibonacci()
        {
            Assert.AreEqual(Program.Fib(0), 0);
            Assert.AreEqual(Program.Fib(1), 1);
            Assert.AreEqual(Program.Fib(2), 1);
            Assert.AreEqual(Program.Fib(10), 55);
            Assert.AreEqual(Program.Fib(20), 6765);
        }
    }
}
