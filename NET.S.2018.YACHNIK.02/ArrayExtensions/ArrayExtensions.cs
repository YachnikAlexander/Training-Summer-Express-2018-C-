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
        /// <param name="method">method for what kind of way filter array. "byInt" or "byString"</param>
        /// <returns>array of number, where exist the digit</returns>
        public static int[] FilterNumbers(int[] source, int digit, string method = "byInt")
        {
            IsValid(source, digit, method);

            int[] arr = StartFilterNumbers(source, digit, method);

            return arr;
        }

        /// <summary>
        /// method for start FilterNumbers
        /// </summary>
        /// <param name="source">array of numbers</param>
        /// <param name="digit">digit what check</param>
        /// <param name="method">method for what kind of way filter array. "byInt" or "byString"</param>
        /// <returns>array of number, where exist the digit</returns>
        private static int[] StartFilterNumbers(int[] source, int digit, String method)
        {
            List<int> list = new List<int>();
            if(method == "byInt")
            {
                for (int i = 0; i < source.Length; i++)
                {
                    if (IsDigit(source[i], digit))
                    {
                        list.Add(source[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < source.Length; i++)
                {
                    if (IsDigitByString(source[i], digit))
                    {
                        list.Add(source[i]);
                    }
                }
            }
            

            int[] listInt = list.ToArray();
            return listInt;
        }
        /// <summary>
        /// check existance of digit in number by string
        /// </summary>
        /// <param name="source">array of numbers</param>
        /// <param name="digit">digit what check</param>
        /// <param name="method">method for what kind of way filter array. "byInt" or "byString"</param>
        /// <returns>bool variable of existance digit in number</returns>
        private static bool IsDigitByString(int number, int digit)
        {
            string numb = number.ToString();
            string dig = digit.ToString();

            bool existence = numb.Contains(dig);
            return existence;
        }

        /// <summary>
        /// validate data
        /// </summary>
        /// <param name="source">array of numbers</param>
        /// <param name="digit">digit what check</param>
        /// <param name="method">method for what kind of way filter array. "byInt" or "byString"</param>
        /// <returns>true, if exceptions dont flies</returns>
        /// <exception cref="ArgumentNullException">flies when source == null</exception>
        /// <exception cref="ArgumentNullException">flies when method == null</exception>
        /// <exception cref="ArgumentException">flies when method != "byInt" and "byString"</exception>
        /// <exception cref="ArgumentException">flies when source.length == 0</exception>
        /// <exception cref="ArgumentNullException">flies when digit less 0 or more than 9</exception>

        private static bool IsValid(int[] source, int digit, string method)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if(method != "byInt")
            {
                if(method == null)
                {
                    throw new ArgumentNullException(nameof(method));
                }

                if(method != "byString")
                {
                    throw new ArgumentException(nameof(method));
                }
            }

            if (source.Length == 0)
            {
                throw new ArgumentException(nameof(source));
            }

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit));
            }

            return true;
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
