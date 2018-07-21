using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchNamespace
{
    public static class BinarySearch 
    {
        /// <summary>
        /// Method for finding index of number by binarySearch
        /// </summary>
        /// <typeparam name="T">type of array and </typeparam>
        /// <param name="array">array in which needed to find item</param>
        /// <param name="item">needed to find</param>
        /// <param name="comparer">delegate for compare to items</param>
        /// <returns>index of number or -1 if isnt exist</returns>
        /// <exception cref="ArgumentNullException">if array is null</exception>
        /// <exception cref="ArgumentNullException">if comparer is null</exception>
        public static int StartBinarySearch<T>(this T[] array, T item, Comparison<T> comparer)
        {
            if(array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                return -1;
            }

            if(comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            return DoBinarySearch(array, item, 0, array.Length - 1, comparer);
        }

        private static int DoBinarySearch<T>(T[] array, T item, int left, int right, Comparison<T> comparer)
        {
            int mid = (right + left) / 2;

            if (left >= right)
            {
                return -1;
            }

            if (comparer.Invoke(array[left], item) == 0)
            {
                return left;
            }

            if (comparer.Invoke(array[mid], item) == 0)
            {
                return mid;
            }

            if ((comparer.Invoke(array[mid], item) > 0))
            {
                return DoBinarySearch(array, item, left, mid, comparer);
            }
            else
            {
                return DoBinarySearch(array, item, mid + 1, right, comparer);
            }
        }
    }
}
