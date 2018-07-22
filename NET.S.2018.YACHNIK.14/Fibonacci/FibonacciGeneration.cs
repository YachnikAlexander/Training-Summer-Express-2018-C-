using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class FibonacciGeneration
    {
        #region Public Api
        /// <summary>
        /// Method for generation Fibonacci array
        /// </summary>
        /// <param name="maxValue">maxValue of numbers from Fibonacci</param>
        /// <returns>array of numbers Fibonacci</returns>
        /// <exception cref="ArgumentException">if maxValue less than zero</exception>
        public static int[] FibonacciGen(this int maxValue)
        {
            if(maxValue < 0)
            {
                throw new ArgumentException(nameof(maxValue));
            }

            List<int> numbers = DoFibonacci(maxValue);

            return numbers.ToArray();
        }
        #endregion

        #region Private Methods
        private static List<int> DoFibonacci(int maxValue)
        {
            List<int> numbers = new List<int>();
            int u = 0, u1 = 0, u2 = 1;

            while (u < maxValue)
            {
                numbers.Add(u);
                u = u1 + u2;
                u1 = u2;
                u2 = u;
            }

            return numbers;
        }
        #endregion
    }
}
