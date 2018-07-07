using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace IEEE754
{
    public static class Converter
    {
        #region Constant
        private const int BITSLONG = 64;
        #endregion

        #region PublicAPI
        /// <summary>
        /// Method to convert doubleBits to string
        /// </summary>
        /// <param name="number">double number needed to convert</param>
        /// <returns>string of bits of number</returns>
        public static string ConvertToString(this double number)
        {
            StructDoubleToLong bitsDouble = new StructDoubleToLong(number);
            long bitsLong = bitsDouble.GetLong();
            string strBits = StartConvert(bitsLong);
            return strBits;
        }
        #endregion

        #region Private
        private static string StartConvert(long bits)
        {
            StringBuilder result = new StringBuilder();

            for(int i=0; i<BITSLONG; i++)
            {
                char item = ((bits & 1) == 1) ? '1' : '0';
                result.Insert(0, item);
                bits >>= 1;
            }

            return result.ToString();
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct StructDoubleToLong
        {
            [FieldOffset(0)]
            private readonly long _long;

            [FieldOffset(0)]
            private readonly double _double;

            public StructDoubleToLong(double value) : this()
            {
                _double = value;
            }

            public long GetLong() => _long;
        }
    }
    #endregion
}
