using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Fibonacci
{
    public static class FibonacciGeneration
    {
        #region Public Api
        /// <summary>
        /// Method for generation Fibonacci array
        /// </summary>
        /// <param name="length">length of numbers from Fibonacci</param>
        /// <returns>IEnumerable of BigInteger? of numbers Fibonacci</returns>
        /// <exception cref="ArgumentException">if length less than zero</exception>
        public static IEnumerable<BigInteger?> FibonacciGen(this int length)
        {
            if (length < 0)
            {
                throw new ArgumentException(nameof(length));
            }

            return DoFibonacci(length);
        }
        #endregion

        #region Private Methods
        private static IEnumerable<BigInteger?> DoFibonacci(int length)
        {
            if (length == 0)
            {
                yield return null;
            }

            long prev = 0;
            long next = 1;

            for (int i = 0; i < length; i++)
            {
                yield return prev;
                long tmp = prev + next;
                prev = next;
                next = tmp;
            }
        }
        #endregion
    }
}
