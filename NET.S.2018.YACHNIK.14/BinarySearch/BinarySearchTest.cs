using System;
using NUnit.Framework;
using BinarySearchNamespace;

namespace BinarySearchTests
{
    [TestFixture]
    public class BinarySearchTest
    {
        Comparison<int> operationInt = (x, y) => x - y;

        [TestCase(new int[] { 1, 3, 5, 7, 9, 11, 18, 29, 34, 67 }, 18, ExpectedResult = 6)]
        
        [Test]
        public int BinarySearchGenericInt(int[] array, int item)
        {
            return array.StartBinarySearch<int>(item, (x, y) => x - y);
        }

        [TestCase(new double[] { 2.5, 6, 8, 11.6, 19, 20, 22.8}, 20, ExpectedResult = 5)]

        [Test]
        public int BinarySearchGenericDouble(double[] array, double item)
        {
            return array.StartBinarySearch<double>(item, (x, y) => (int)(x - y));
        }


        [TestCase(null, 16)]
        public void BinarySearchGenericNullArray(double[] array, int item)
        {
            Assert.Throws<ArgumentNullException>(() => array.StartBinarySearch<double>(item, (x, y) => (int)(x - y)));
        }

        [TestCase(new int[] { 1, 3, 5, 7, 9, 11, 18, 29, 34, 67 }, 18)]
        public void BinarySearchGenericComparerNull(int[] array, int item)
        {
            Assert.Throws<ArgumentNullException>(() => array.StartBinarySearch<int>(item, null));
        }
    }
}
