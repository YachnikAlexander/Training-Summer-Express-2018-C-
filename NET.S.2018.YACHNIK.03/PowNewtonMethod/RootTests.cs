using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NRootTests
{
    [TestClass]
    public class RootTests
    {
        [TestMethod]
        public void FirstTest_1_5_afterDecpoint0001()
        {
            double number = 1;
            int degree = 5;
            double accuracy = 0.0001;
            double expected = 1;

            double actual = FindingNRoot.RootNDegree.NewtonNRoot(number, degree, accuracy);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecondTest_8_3_afterDecpoint0001()
        {
            double number = 8;
            int degree = 3;
            double accuracy = 0.0001;
            double expected = 2;

            double actual = FindingNRoot.RootNDegree.NewtonNRoot(number, degree, accuracy);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThirdTest_001_3_afterDecpoint0001()
        {
            double number = 0.001;
            int degree = 3;
            double accuracy = 0.0001;
            double expected = 0.1;

            double actual = FindingNRoot.RootNDegree.NewtonNRoot(number, degree, accuracy);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ForthTest_04100625_4_afterDecpoint0001()
        {
            double number = 0.04100625;
            int degree = 4;
            double accuracy = 0.0001;
            double expected = 0.45;

            double actual = FindingNRoot.RootNDegree.NewtonNRoot(number, degree, accuracy);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FifthTest_0279936_7_afterDecpoint0001()
        {
            double number = 0.0279936;
            int degree = 7;
            double accuracy = 0.0001;
            double expected = 0.6;

            double actual = FindingNRoot.RootNDegree.NewtonNRoot(number, degree, accuracy);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SixsTest_0081_4_afterDecpoint01()
        {
            double number = 0.0081;
            int degree = 4;
            double accuracy = 0.01;
            double expected = 0.3;

            double actual = FindingNRoot.RootNDegree.NewtonNRoot(number, degree, accuracy);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void SevensTest_Minus008_3_afterDecpoint1()
        {
            double number = -0.008;
            int degree = 3;
            double accuracy = 0.1;
            double expected = - 0.2;
            double actual = FindingNRoot.RootNDegree.NewtonNRoot(number, degree, accuracy);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Minus01_2_afterDecpoint0001_ArgumentException()
        {
            double number = -0.01;
            int degree = 2;
            double accuracy = 0.0001;
            double actual = FindingNRoot.RootNDegree.NewtonNRoot(number, degree, accuracy);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_afterDecpoint001_Minus2_afterDecpoint0001_argumentException()
        {
            double number = 0.001;
            int degree = -2;
            double accuracy = 0.0001;
            double actual = FindingNRoot.RootNDegree.NewtonNRoot(number, degree, accuracy);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_afterDecpoint01_2_Minus1_argumentException()
        {
            double number = 0.001;
            int degree = -2;
            double accuracy = 0.0001;

            double actual = FindingNRoot.RootNDegree.NewtonNRoot(number, degree, accuracy);
        }
    }
}
