using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    public static class ArrayExtensionByFilter
    {
        /// <summary>
        /// method for filtration elements from array
        /// </summary>
        /// <typeparam name="T">any type of variables</typeparam>
        /// <param name="array">array</param>
        /// <param name="predicate">predicate-delegate on which comparing</param>
        /// <returns>array of true elements</returns>
        public static T[] Filter<T>(this T[] array, Predicate<T> predicate)
        {
            Validate(array, predicate);

            List<T> result = new List<T>();
            
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// method for filtration elements from array
        /// </summary>
        /// <typeparam name="T">any type of variables</typeparam>
        /// <param name="array">array</param>
        /// <param name="predicate">predicate-interface on which comparing</param>
        /// <returns>array of true elements</returns>
        public static T[] Filter<T>(this T[] array, IPredicate<T> predicate)
        {
            if(array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            return array.Filter(predicate.IsMatch);
        }

        #region Private Methods
        private static void Validate<T>(T[] array, Predicate<T> predicate)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
        }
        #endregion
    }
}
