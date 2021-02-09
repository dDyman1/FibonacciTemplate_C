using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fibonacci;

namespace FibonacciTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFibonacci()
        {
            int testing = Program.Fib(9);
            Console.WriteLine(testing);
            Assert.AreEqual(testing, 34);
        }
    }
}
