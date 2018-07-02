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
            Random rnd = new Random();
            int[] array = new int[500];
            
            for(int i=0; i<array.Length; i++)
            {
                array[i] = rnd.Next();
            }

            ArraySorting.Sort.MergeSort(array);

            if (!IsSortedArray(array))
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// TTesting MergeSort for  method with 3 argument 
        /// </summary>
        [TestMethod]
        public void MergeSortTest()
        {
            Random rnd = new Random();
            int[] array = new int[500];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }

            ArraySorting.Sort.MergeSort(array, 30, 80);

            if (!IsSortedArray(array, 30, 80))
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Testing ArgumentException for empty array MergeSort
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyArrayMergeTest()
        {
            int[] array = new int[] { };
            ArraySorting.Sort.MergeSort(array);
        }

        /// <summary>
        /// Testing ArgumentNullException for null array MergeSort
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullArrayMergeTest()
        {
            int[] array = null;
            ArraySorting.Sort.MergeSort(array);
        }

        /// <summary>
        /// Testing MergeSort for overloaded method with 1 argument 
        /// </summary>
        [TestMethod]
        public void QuickSortOverloadedTest()
        {
            Random rnd = new Random();
            int[] array = new int[500];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }

            ArraySorting.Sort.QuickSort(array);

            if (!IsSortedArray(array))
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Testing MergeSort for method with 3 argument 
        /// </summary>
        [TestMethod]
        public void QuickSortTest()
        {
            Random rnd = new Random();
            int[] array = new int[500];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }

            ArraySorting.Sort.QuickSort(array, 30, 80);

            if (!IsSortedArray(array, 30, 80))
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Testing ArgumentException for emptyArray Quick Sort
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyArrayQuickTest()
        {
            int[] array = new int[] { };
            ArraySorting.Sort.QuickSort(array);
        }

        /// <summary>
        /// Testing ArgumentNullException for emptyArray Quick Sort
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullArrayQuickTest()
        {
            int[] array = null;
            ArraySorting.Sort.QuickSort(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArrayTestleftMoreThanRight()
        {
            int[] array = new[]{1, 2};
            ArraySorting.Sort.QuickSort(array, 2, 1);
        }

        public static bool IsSortedArray(int[] array, int from = 0, int to = -1) {
            if(to == -1)
            {
                to = array.Length;
            }

            for(int i=from; i<to - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
