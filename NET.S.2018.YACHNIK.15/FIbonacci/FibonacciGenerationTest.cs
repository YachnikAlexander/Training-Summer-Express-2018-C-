using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections;
using NUnit.Framework;
using Fibonacci;
using System.Numerics;

namespace FibonacciTests
{
    [TestFixture]
    public class FibonacciGenerationTest
    {
        public static IEnumerable GenerateFibbonachiArray
        {
            get
            {
                yield return new TestCaseData(5).Returns(new BigInteger[] { 0, 1, 1, 2, 3 });
                yield return new TestCaseData(10).Returns(new BigInteger[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 });
            }
        }

        [Test, TestCaseSource(nameof(GenerateFibbonachiArray))]
        public IEnumerable FibonacciSequenceEnumerable(int length) => length.FibonacciGen();

        public static IEnumerable ExceptionTest
        {
            get
            {
                yield return new TestCaseData(-10);
                yield return new TestCaseData(-1);
            }
        }

        [Test, TestCaseSource(nameof(ExceptionTest))]
        public void ArgumentExceptionLength(int length)
        {
            Assert.Throws<ArgumentException>(() => length.FibonacciGen());
        }
    }
}
