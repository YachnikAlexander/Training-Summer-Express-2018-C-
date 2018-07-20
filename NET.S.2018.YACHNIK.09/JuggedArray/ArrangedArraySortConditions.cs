using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrangedArray
{
    /// <summary>
    /// class for calculating increasing sum
    /// </summary>
    public class IncreasingSum : IComparer<int[]>
    {
        /// <summary>
        /// Method for comparing 
        /// </summary>
        /// <param name="firstArray">first array</param>
        /// <param name="secondArray">second array</param>
        /// <returns>Differenct between sums</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null && secondArray == null)
            {
                return 0;
            }
            if (firstArray == null)
            {
                return 1;
            }
            if (secondArray == null)
            {
                return -1;
            }
            return firstArray.Sum() - secondArray.Sum();
        }
    }

    /// <summary>
    /// class for calculating decreasing sum
    /// </summary>
    public class DecreasingSum : IComparer<int[]>
    {
        /// <summary>
        /// Method for comparing 
        /// </summary>
        /// <param name="firstArray">first array</param>
        /// <param name="secondArray">second array</param>
        /// <returns>Differenct between sums</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null && secondArray == null)
            {
                return 0;
            }
            if (firstArray == null)
            {
                return -1;
            }
            if (secondArray == null)
            {
                return 1;
            }
            return secondArray.Sum() - firstArray.Sum();
        }
    }

    /// <summary>
    /// class for calculating increasing max element sum
    /// </summary>
    public class IncreasingMaxElement : IComparer<int[]>
    {
        /// <summary>
        /// Method for comparing 
        /// </summary>
        /// <param name="firstArray">first array</param>
        /// <param name="secondArray">second array</param>
        /// <returns>Differenct between sums</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null && secondArray == null)
            {
                return 0;
            }
            if (firstArray == null)
            {
                return 1;
            }
            if (secondArray == null)
            {
                return -1;
            }
            return firstArray.Max() - secondArray.Max();
        }
    }

    /// <summary>
    /// class for calculating decreasing max element sum
    /// </summary>
    public class DecreasingMaxElement : IComparer<int[]>
    {
        /// <summary>
        /// Method for comparing 
        /// </summary>
        /// <param name="firstArray">first array</param>
        /// <param name="secondArray">second array</param>
        /// <returns>Differenct between sums</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null && secondArray == null)
            {
                return 0;
            }
            if (firstArray == null)
            {
                return 1;
            }
            if (secondArray == null)
            {
                return -1;
            }
            return secondArray.Max() - firstArray.Max();
        }
    }

    /// <summary>
    /// class for calculating increasing Min element sum
    /// </summary>
    public class IncreasingMinElement : IComparer<int[]>
    {
        /// <summary>
        /// Method for comparing 
        /// </summary>
        /// <param name="firstArray">first array</param>
        /// <param name="secondArray">second array</param>
        /// <returns>Differenct between sums</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null && secondArray == null)
            {
                return 0;
            }
            if (firstArray == null)
            {
                return 1;
            }
            if (secondArray == null)
            {
                return -1;
            }
            return firstArray.Min() - secondArray.Min();
        }
    }

    /// <summary>
    /// class for calculating decreasingMinElement sum
    /// </summary>
    public class DecreasingMinElement : IComparer<int[]>
    {
        /// <summary>
        /// Method for comparing 
        /// </summary>
        /// <param name="firstArray">first array</param>
        /// <param name="secondArray">second array</param>
        /// <returns>Differenct between sums</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null && secondArray == null)
            {
                return 0;
            }
            if (firstArray == null)
            {
                return 1;
            }
            if (secondArray == null)
            {
                return -1;
            }
            return secondArray.Min() - firstArray.Min();
        }
    }
}
