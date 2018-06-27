using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// extension for array to determine the digit in number
/// </summary>
namespace ArrayExtensions
{
    /// <summary>
    /// class to determine digit
    /// </summary>
    public class ArrayExtensions
    {
        /// <summary>
        /// extension method for validate
        /// </summary>
        /// <param name="source">array of numbers</param>
        /// <param name="digit">digit what check</param>
        /// <returns>list of number, where exist the digit</returns>
        public static List<int> FilterNumbers(int[] source, int digit)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException(nameof(source));
            }

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit));
            }

            List<int> list = new List<int>();

            for (int i = 0; i < source.Length; i++)
            {
                if (IsDigit(source[i], digit))
                {
                    list.Add(source[i]);
                }
            }

            return list;
        }

        /// <summary>
        /// method to determine the existance of digit
        /// </summary>
        /// <param name="number">number for checking</param>
        /// <param name="digit">digit what check</param>
        /// <returns>return true or false based on exist of digit in number</returns>
        private static bool IsDigit(int number, int digit)
        {
            if (digit != 0)
            {
                if (number < 0)
                {
                    number *= -1;
                }

                while (number != 0)
                {
                    int t = number % 10;

                    if (t == digit)
                    {
                        return true;
                    }

                    number /= 10;
                }
            }
            else
            {
                if (number == 0 || number % 10 == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
