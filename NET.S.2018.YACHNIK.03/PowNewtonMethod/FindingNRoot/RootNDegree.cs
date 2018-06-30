using System;

/// <summary>
/// find root of n-degree by some
/// </summary>
namespace FindingNRoot
{
    /// <summary>
    /// class for finding root of n-degree
    /// </summary>
    public class RootNDegree
    {
        /// <summary>
        /// public static method for finding root of n-degree by Newton method
        /// </summary>
        /// <param name="number">number of which must to find root</param>
        /// <param name="degree">degree of root</param>
        /// <param name="accuracy">accuracy of ending result</param>
        /// <returns>root n-degree's for number</returns>
        public static double NewtonNRoot(double number, int degree, double accuracy)
        {
            IsValid(number, degree, accuracy);

            double root = StartNewtonNRoot(number, degree, accuracy);

            return root;
        }

        /// <summary>
        /// method for start finding root
        /// </summary>
        /// <param name = "number"> number of which must to find root</param>
        /// <param name="degree">degree of root</param>
        /// <param name="accuracy">accuracy of ending result</param>
        /// <returns>root n-degree's for number</returns>
        private static double StartNewtonNRoot(double number, int degree, double accuracy)
        {
            double root = ((degree - 1) + number) / degree;
            double num = 1;

            while (Math.Abs(root - num) > accuracy)
            {
                num = root;
                root = (((degree - 1) * num) + (number / Math.Pow(num, degree - 1))) / degree;
            }

            double one = 1;
            int counter = 0;

            while (one > accuracy)
            {
                one *= 0.1;
                root *= 10;
                counter++;
            }

            if (root < 0)
            {
                root /= Pow(10, counter);
                root = Math.Round(root, counter);
            }
            else
            {
                root /= Pow(10, counter);
                root = Math.Round(root, counter - 1);
            }

            return root;
        }

        /// <summary>
        /// method for finding pow of number
        /// </summary>
        /// <param name="number">number of which must to find pow</param>
        /// <param name="pow">needing pow</param>
        /// <returns>resulting pow of number</returns>
        private static double Pow(double number, int pow)
        {
            double result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }

            return result;
        }

        /// <summary>
        /// Method for validate data
        /// </summary>
        /// <param name = "number">number of which must to find root</param>
        /// <param name="degree">degree of root</param>
        /// <param name="accuracy">accuracy of ending result</param>
        /// <returns>bool value of data validity</returns>
        /// <exception cref="ArgumentException">number less than 0 and degree is even number</exception>
        /// <exception cref="ArgumentException">degree less than 0</exception>
        /// <exception cref="ArgumentException">accuracy less than 0 or more than 1</exception>
        /// <exception cref="ArgumentException">accuracy has a misconception dont like 0.0001</exception>
        private static bool IsValid(double number, int degree, double accuracy)
        {
            if (number < 0 && degree % 2 == 0)
            {
                throw new ArgumentException($"number {0} less than 0 and degreeeven number", nameof(number));
            }

            if (degree < 0)
            {
                throw new ArgumentException($"degree {0} less than 0", nameof(degree));
            }

            if (!(accuracy < 1 && accuracy > 0))
            {
                throw new ArgumentException($"accuracy {0} is invalid", nameof(accuracy));
            }

            if (!IsValidAccuracy(accuracy))
            {
                throw new ArgumentException($"incorect type of {0}", nameof(accuracy));
            }

            return true;
        }

        /// <summary>
        /// method for validate entering accuracy
        /// </summary>
        /// <param name="accuracy">accuracy of calculation</param>
        /// <returns>bool value of accuracy validity</returns>
        private static bool IsValidAccuracy(double accuracy)
        {
            string accuracyStr = accuracy.ToString();

            string[] arrSplit = accuracyStr.Split(',');

            int number;
            bool flag = Int32.TryParse(arrSplit[1], out number);

            if (flag)
            {
                if (number != 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
