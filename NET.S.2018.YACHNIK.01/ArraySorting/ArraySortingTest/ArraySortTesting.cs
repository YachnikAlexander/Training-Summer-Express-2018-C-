using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArraySortingTest
{
    /// <summary>
    /// Testing class Sort, exactly Merge and Quick
    /// </summary>
    [TestClass]
    public class ArraySortingTest
    {
        /// <summary>
        /// Testing MergeSort for overloaded method with 1 argument 
        /// </summary>
        [TestMethod]
        public void MergeSortOverloadedTest()
        {
            ////Aranged Act Assert (AAA) Pattern

            ////Arrange
            int[] array = new int[] { 1, 2, 77, 7, 701 };
            int[] expected = new int[] { 1, 2, 7, 77, 701 };
            ////Act
            int[] actual = ArraySorting.Sort.MergeSort(array);
            ////Asset
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TTesting MergeSort for  method with 3 argument 
        /// </summary>
        [TestMethod]
        public void MergeSortTest()
        {
            ////Aranged Act Assert (AAA) Pattern

            ////Arrange
            int[] array = new int[] { 1, 77, 2, 7, 701 };
            int[] expected = new int[] { 1, 2, 77, 7, 701 };
            ////Act
            int[] actual = ArraySorting.Sort.MergeSort(array, 0, 2);
            ////Asset
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Testing ArgumentException for empty array MergeSort
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyArrayMergeTest()
        {
            int[] array = new int[] { };
            int[] actual = ArraySorting.Sort.MergeSort(array);
        }

        /// <summary>
        /// Testing ArgumentNullException for null array MergeSort
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullArrayMergeTest()
        {
            int[] array = null;
            int[] actual = ArraySorting.Sort.MergeSort(array);
        }

        /// <summary>
        /// Testing MergeSort for overloaded method with 1 argument 
        /// </summary>
        [TestMethod]
        public void QuickSortOverloadedTest()
        {
            ////Aranged Act Assert (AAA) Pattern
            ////Arrange
            int[] array = new int[] { 1, 2, 77, 7, 701 };
            int[] expected = new int[] { 1, 2, 7, 77, 701 };
            ////Act
            int[] actual = ArraySorting.Sort.QuickSort(array);
            ////Asset
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Testing MergeSort for method with 3 argument 
        /// </summary>
        [TestMethod]
        public void QuickSortTest()
        {
            ////Aranged Act Assert (AAA) Pattern

            ////Arrange
            int[] array = new int[] { 1, 77, 2, 7, 701 };
            int[] expected = new int[] { 1, 2, 77, 7, 701 };
            ////Act
            int[] actual = ArraySorting.Sort.QuickSort(array, 0, 2);
            ////Asset
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Testing ArgumentException for emptyArray Quick Sort
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyArrayQuickTest()
        {
            int[] array = new int[] { };
            int[] actual = ArraySorting.Sort.QuickSort(array);
        }

        /// <summary>
        /// Testing ArgumentNullException for emptyArray Quick Sort
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullArrayQuickTest()
        {
            int[] array = null;
            int[] actual = ArraySorting.Sort.QuickSort(array);
        }
    }
}
