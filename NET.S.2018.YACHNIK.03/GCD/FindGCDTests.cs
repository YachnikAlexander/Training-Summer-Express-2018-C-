using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindGCD;

namespace FindGCD.Test
{
    [TestClass]
    public class FindGCDTests
    {
        [TestMethod]
        public void EuclidGCD_15_25()
        {
            int firstNumber = 15;
            int secondNumber = 25;
            int expected = 5;

            int actual = FindGCD.FindEuclidGCD(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclidGCD_34_68()
        {
            int firstNumber = 34;
            int secondNumber = 68;
            int expected = 34;

            int actual = FindGCD.FindEuclidGCD(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclidGCD_17_8()
        {
            int firstNumber = 17;
            int secondNumber = 8;
            int expected = 1;

            int actual = FindGCD.FindEuclidGCD(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclidGCD_24_16()
        {
            int firstNumber = 24;
            int secondNumber = 16;
            int expected = 8;

            int actual = FindGCD.FindEuclidGCD(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclidGCD_24_0()
        {
            int firstNumber = 24;
            int secondNumber = 0;
            int expected = 24;

            int actual = FindGCD.FindEuclidGCD(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclidGCD_0_67()
        {
            int firstNumber = 0;
            int secondNumber = 67;
            int expected = 67;

            int actual = FindGCD.FindEuclidGCD(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclidGCD_0_0()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int expected = 0;

            int actual = FindGCD.FindEuclidGCD(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EuclidGCD_minus10_15()
        {
            int firstNumber = -10;
            int secondNumber = 15;
            int expected = 5;

            int actual = FindGCD.FindEuclidGCD(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinGCD_10_15_20()
        {
            int firstNumber = 10;
            int secondNumber = 15;
            int thirdNumber = 20;
            int expected = 5;

            int actual = FindGCD.FindSteinGCD(firstNumber, secondNumber, thirdNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinGCD_8_12_28_32()
        {
            int firstNumber = 8;
            int secondNumber = 12;
            int thirdNumber = 28;
            int forthNumber = 32;
            int expected = 4;

            int actual = FindGCD.FindSteinGCD(firstNumber, secondNumber, thirdNumber, forthNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinGCD_minus12_18_36()
        {
            int firstNumber = -12;
            int secondNumber = 18;
            int thirdNumber = 36;
            int expected = 6;

            int actual = FindGCD.FindSteinGCD(firstNumber, secondNumber, thirdNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinGCD_0_18_36()
        {
            int firstNumber = 0;
            int secondNumber = 18;
            int thirdNumber = 36;
            int expected = 18;

            int actual = FindGCD.FindSteinGCD(firstNumber, secondNumber, thirdNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinGCD_0_14_0()
        {
            int firstNumber = 0;
            int secondNumber = 14;
            int thirdNumber = 0;
            int expected = 14;

            int actual = FindGCD.FindSteinGCD(firstNumber, secondNumber, thirdNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinGCD_0_0_0()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int expected = 0;

            int actual = FindGCD.FindSteinGCD(firstNumber, secondNumber, thirdNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SteinGCD_minus10_minus14_minus20()
        {
            int firstNumber = -10;
            int secondNumber = -14;
            int thirdNumber = -20;
            int expected = 2;

            int actual = FindGCD.FindSteinGCD(firstNumber, secondNumber, thirdNumber);

            Assert.AreEqual(expected, actual);
        }
    }
}
