using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FindGCD
{
    /// <summary>
    /// Class for finding Gcd of 2 or more numbers
    /// </summary>
    public class FindGCD
    {
        #region PublicApi

        /// <summary>
        /// Get the Time of working some methods
        /// </summary>
        /// <value>Stopwatch  time</value>
        public static Stopwatch Time { get; private set; }

        /// <summary>
        /// public method for finding GCD of 2 numbers by Euclid method
        /// </summary>
        /// <param name="firstNumber">first number of which must to find Gcd</param>
        /// <param name="secondNumber">second number of which must to find Gcd</param>
        /// <returns>Gcd of numbers</returns>
        public static int FindEuclidGCD(int firstNumber, int secondNumber)
        {
            if (СheckData(firstNumber, secondNumber))
            {
                int gcd = StartFindEuclidGCD(firstNumber, secondNumber);

                return gcd;
            }
            else
            {
                if (firstNumber != 0)
                {
                    return firstNumber;
                }

                if (secondNumber != 0)
                {
                    return secondNumber;
                }

                return 0;
            }
        }

        /// <summary>
        /// public method for finding GCD of 2 numbers by Stein method
        /// </summary>
        /// <param name="numbers"> numbers of which must to find Gcd</param>
        /// <returns>Gcd of numbers</returns>
        public static int FindSteinGCD(params int[] numbers)
        {
            int gcd = StartFindSteinGCD(numbers);
            return gcd;
        }

        /// <summary>
        /// Method for fixation time of work FindEuclidGCD
        /// </summary>
        /// <returns>time of work of method</returns>
        public static string TimeOfWork_FindEuclidGCD()
        {

            FindGCD.Time = new Stopwatch();
            Time.Start();

            FindEuclidGCD(10, 15);

            Time.Stop();
            TimeSpan time = FindGCD.Time.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", time.Hours, time.Minutes, time.Seconds, time.Milliseconds / 10);

            return elapsedTime;
        }

        /// <summary>
        /// Method for fixation time of work FindEuclidGCD
        /// </summary>
        /// <returns>time of work of method</returns>
        public static string TimeOfWork_FindSteinGCD()
        {

            FindGCD.Time = new Stopwatch();
            Time.Start();

            FindSteinGCD(10, 15, 22);

            Time.Stop();
            TimeSpan time = FindGCD.Time.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", time.Hours, time.Minutes, time.Seconds, time.Milliseconds / 10);

            return elapsedTime;
        }

        #endregion

        #region PrivateMethods

        /// <summary>
        /// method for starting find GCD by Stein
        /// </summary>
        /// <param name="numbers">numbers of which must to find Gcd</param>
        /// <returns>gcd of numbers</returns>
        private static int StartFindSteinGCD(int[] numbers)
        {
            int gcd = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (gcd == 1)
                {
                    break;
                }

                gcd = SteinGCD(gcd, numbers[i]);
            }

            return gcd;
        }

        /// <summary>
        /// Method for finding gcd of 2 numbers by Stein
        /// </summary>
        /// <param name="firstNumber">first number of which must to find</param>
        /// <param name="secondNumber">second number of which must to find</param>
        /// <returns>gcd of 2 numbers</returns>
        private static int SteinGCD(int firstNumber, int secondNumber)
        {
            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);

            if (firstNumber == secondNumber)
            { 
                return firstNumber;
            }

            if (firstNumber == 0)
            {
                return secondNumber;
            }
               
            if (secondNumber == 0)
            {
                return firstNumber;
            }
                
            if ((~firstNumber & 1) != 0)
            {
                if ((secondNumber & 1) != 0)
                {
                    return SteinGCD(firstNumber >> 1, secondNumber);
                }
                else
                {
                    return SteinGCD(firstNumber >> 1, secondNumber >> 1) << 1;
                }
            }

            if ((~secondNumber & 1) != 0)
            {
                return SteinGCD(firstNumber, secondNumber >> 1);
            }

            if (firstNumber > secondNumber)
            {
                return SteinGCD((firstNumber - secondNumber) >> 1, secondNumber);
            }

            return SteinGCD((secondNumber - firstNumber) >> 1, firstNumber);
        }

        /// <summary>
        /// Method for starting finding gcd of 2 numbers by Euclid
        /// </summary>
        /// <param name="firstNumber">first number of which must to find</param>
        /// <param name="secondNumber">second number of which must to find</param>
        /// <returns>after recursion return gcd of 2 numbers</returns>
        private static int StartFindEuclidGCD(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                firstNumber = Math.Abs(firstNumber);
                return firstNumber;
            }

            return StartFindEuclidGCD(secondNumber, firstNumber % secondNumber);
        }

        /// <summary>
        /// Method for check entering data
        /// </summary>
        /// <param name="firstNumber">first number of which must to find gcd</param>
        /// <param name="secondNumber">second number of which must to find gcd</param>
        /// <returns>bool value of check Data</returns>
        private static bool СheckData(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                return false;
            }

            return true;
        }
        #endregion
    }
}
