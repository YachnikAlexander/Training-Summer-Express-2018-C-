using System;
using NUnit.Framework;
using Fibonacci;

namespace FibonacciTests
{
    [TestFixture]
    public class FibonacciGenerationTest
    {
        [TestCase(18, ExpectedResult = new int[] {0, 1, 2, 3, 5, 8, 13})]

        [Test]
        public int[] FibonacciTest(int maxValue)
        {
            return maxValue.FibonacciGen();
        }

        [TestCase(-2)]
        public void FibonacciTestLessThanZero(int maxValue)
        {
            Assert.Throws<ArgumentException>(() => maxValue.FibonacciGen());
        }
    }
}
