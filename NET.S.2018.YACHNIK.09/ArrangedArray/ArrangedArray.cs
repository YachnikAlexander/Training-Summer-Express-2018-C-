using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrangedArray
{
    /// <summary>
    /// Class for sorting arrays
    /// </summary>
    public static class ArrangedArray
    {
        #region PublicApi
        /// <summary>
        /// Method for sorting array by bubleSort and 
        /// presentation according to the conditions
        /// </summary>
        /// <typeparam name="T">the type of array's elements</typeparam>
        /// <param name="arr"> array needed to sort</param>
        /// <param name="comparer">condition of presentation</param>
        /// <exception cref="ArgumentNullException">Array is null</exception>
        /// <exception cref="ArgumentNullException">comparer is null</exception>
        public static void BubbleSort<T>(this T[][] arr, ICompare<T> comparer)
        {
            Validate(arr, comparer);

            bool flag = true;

            while (flag)
            {
                flag = false;

                for (int i = 0; i < arr.Length-1; i++)
                {
                    if((comparer.Compare(arr[i], arr[i + 1]) > 0)){
                        Swap(ref arr[i], ref arr[i + 1]);
                        flag = true;
                    }
                }
            }

        }

        /// <summary>
        /// Method for calculating sum of array
        /// </summary>
        /// <param name="arr">array of which nedeed to calculate sum</param>
        /// <returns>sum of array</returns>
        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        #endregion

        #region Private members
        private static void Swap<T>(ref T[] firstItem,ref T[] secondItem)
        {
            T[] swapItem = firstItem;
            firstItem = secondItem;
            secondItem = swapItem;
        }

        private static int MaxItem(int[] arr)
        {
            int maxItem = arr[0];
            for(int i=1; i<arr.Length; i++)
            {
                if (maxItem < arr[i])
                {
                    maxItem = arr[i];
                }
            }
            return maxItem;
        }

        private static int MinItem(int[] arr)
        {
            int minItem = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (minItem < arr[i])
                {
                    minItem = arr[i];
                }
            }
            return minItem;
        }

        private static void Validate<T>(T[][] arr, ICompare<T> comparer)
        {
            if (arr == null)
            {
                throw new ArgumentNullException($"The argument {nameof(arr)} ");
            }
            if (comparer == null)
            {
                throw new ArgumentNullException($"{nameof(comparer)}");
            }
        }

        #endregion
    }
}
