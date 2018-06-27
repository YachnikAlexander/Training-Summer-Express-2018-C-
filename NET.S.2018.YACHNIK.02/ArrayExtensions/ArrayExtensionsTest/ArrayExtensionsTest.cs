using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayExtensions;

/// <summary>
/// namespace for testing ArrayExtension
/// </summary>
namespace ArrayExtensionsTest
{
    /// <summary>
    /// class for testing methods
    /// </summary>
    [TestClass]
    public class ArrayExtensionsTest
    {
        /// <summary>
        /// Testing valid code for Positiv numbers
        /// </summary>
        [TestMethod]
        public void PositivNumbersArrayTest()
        {
            int[] array = new int[] { 1, 2, 77, 7, 701 };
            int digit = 7;

            List<int> expected = new List<int>() { 77, 7, 701 };

            List<int> actual = ArrayExtensions.ArrayExtensions.FilterNumbers(array, digit);

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Testing valid code for Positiv and Negative numbers
        /// </summary>
        [TestMethod]
        public void PositivNegativNumbersArrayTest()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, -7, 68, 69, 70, 15, -17 };
            int digit = 7;
            List<int> expected = new List<int>() { -7, 70, -17 };
            List<int> actual = ArrayExtensions.ArrayExtensions.FilterNumbers(array, digit);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// check exception for negative digit
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArrayTest_digit()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, -7, 68, 69, 70, 15, -17 };
            int digit = -7;
            List<int> actual = ArrayExtensions.ArrayExtensions.FilterNumbers(array, digit);
        }

        /// <summary>
        /// check exception for empty Array
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArrayEmptyTest()
        {
            int[] array = new int[] { };
            int digit = 7;
            List<int> actual = ArrayExtensions.ArrayExtensions.FilterNumbers(array, digit);
        }

        /// <summary>
        /// check exception for null array
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArrayNullTest()
        {
            int[] array = null;
            int digit = 7;
            List<int> actual = ArrayExtensions.ArrayExtensions.FilterNumbers(array, digit);
        }

        /// <summary>
        /// check valid code for digit = 0
        /// </summary>
        [TestMethod]
        public void ZeroDigitArrayExpensionsTest()
        {
            int[] array = new int[] { 0, 10, 20, 111, 456 };
            int digit = 0;
            List<int> expected = new List<int>() { 0, 10, 20 };
            List<int> actual = ArrayExtensions.ArrayExtensions.FilterNumbers(array, digit);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
