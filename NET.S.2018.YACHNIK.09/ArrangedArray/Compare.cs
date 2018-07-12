using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrangedArray
{
    /// <summary>
    /// Interface for comparing by othe type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICompare<T>
    {
        /// <summary>
        /// Method for comparing 
        /// </summary>
        /// <param name="firstArray">first array</param>
        /// <param name="secondArray">second array</param>
        /// <returns>int of comparing</returns>
        int Compare(T[] firstArray, T[] secondArray);
    }
}
