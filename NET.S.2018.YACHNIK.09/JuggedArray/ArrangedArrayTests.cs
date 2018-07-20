using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrangedArray;

namespace ArrangedArray.Test
{
    [TestClass]
    public class ArrangedArrayTests
    {
        [TestMethod]
        public void IncreasingSumTest()
        {
            int[][] actual = new int[4][];
            actual[0] = new int[] { 1, 2, 5, 6 }; //14
            actual[1] = new int[] { 5, 7, 9, 17, 19 }; //57
            actual[2] = new int[] { 23, 8, 9 };//40
            actual[3] = new int[] { 1, 2, 0, 6 };//9

            int[][] execute = new int[4][];
            execute[0] = new int[] { 1, 2, 0, 6 };
            execute[1] = new int[] { 1, 2, 5, 6 };
            execute[2] = new int[] { 23, 8, 9 };
            execute[3] = new int[] { 5, 7, 9, 17, 19 };

            actual.BubbleSort(new IncreasingSum());

            for(int i=0; i<execute.Length; i++)
            {
                CollectionAssert.AreEqual(actual[i], execute[i]);
            }
        }

        [TestMethod]
        public void DecreasingSumTest()
        {
            int[][] actual = new int[4][];
            actual[0] = new int[] { 1, 2, 5, 6 }; //14
            actual[1] = new int[] { 5, 7, 9, 17, 19 }; //57
            actual[2] = new int[] { 23, 8, 9 };//40
            actual[3] = new int[] { 1, 2, 0, 6 };//9

            int[][] execute = new int[4][];
            execute[3] = new int[] { 1, 2, 0, 6 };
            execute[2] = new int[] { 1, 2, 5, 6 };
            execute[1] = new int[] { 23, 8, 9 };
            execute[0] = new int[] { 5, 7, 9, 17, 19 };

            actual.BubbleSort(new DecreasingSum());

            for (int i = 0; i < execute.Length; i++)
            {
                CollectionAssert.AreEqual(actual[i], execute[i]);
            }
        }

        [TestMethod]
        public void IncreasingMaxElementTest()
        {
            int[][] actual = new int[4][];
            actual[0] = new int[] { 1, 2, 5, 6 }; //6
            actual[1] = new int[] { 5, 7, 9, 17, 19 }; //19
            actual[2] = new int[] { 23, 8, 9 };//23
            actual[3] = new int[] { 1, 2, 0, 5 };//5

            int[][] execute = new int[4][];
            execute[0] = new int[] { 1, 2, 0, 5 };
            execute[1] = new int[] { 1, 2, 5, 6 };
            execute[3] = new int[] { 23, 8, 9 };
            execute[2] = new int[] { 5, 7, 9, 17, 19 };

            actual.BubbleSort(new IncreasingMaxElement());

            for (int i = 0; i < execute.Length; i++)
            {
                CollectionAssert.AreEqual(actual[i], execute[i]);
            }
        }

        [TestMethod]
        public void DecreasingMaxElementTest()
        {
            int[][] actual = new int[4][];
            actual[0] = new int[] { 1, 2, 5, 6 }; //14
            actual[1] = new int[] { 5, 7, 9, 17, 19 }; //57
            actual[2] = new int[] { 23, 8, 9 };//40
            actual[3] = new int[] { 1, 2, 0, 6 };//9

            int[][] execute = new int[4][];
            execute[3] = new int[] { 1, 2, 0, 6 };
            execute[2] = new int[] { 1, 2, 5, 6 };
            execute[0] = new int[] { 23, 8, 9 };
            execute[1] = new int[] { 5, 7, 9, 17, 19 };

            actual.BubbleSort(new DecreasingMaxElement());

            for (int i = 0; i < execute.Length; i++)
            {
                CollectionAssert.AreEqual(actual[i], execute[i]);
            }
        }

        [TestMethod]
        public void IncreasingMinElementTest()
        {
            int[][] actual = new int[4][];
            actual[0] = new int[] { 1, 2, 5, 6 }; //14
            actual[1] = new int[] { 5, 7, 9, 17, 19 }; //57
            actual[2] = new int[] { 23, 8, 9 };//40
            actual[3] = new int[] { 1, 2, 0, 6 };//9

            int[][] execute = new int[4][];
            execute[0] = new int[] { 1, 2, 0, 6 };
            execute[1] = new int[] { 1, 2, 5, 6 };
            execute[3] = new int[] { 23, 8, 9 };
            execute[2] = new int[] { 5, 7, 9, 17, 19 };

            actual.BubbleSort(new IncreasingMinElement());

            for (int i = 0; i < execute.Length; i++)
            {
                CollectionAssert.AreEqual(actual[i], execute[i]);
            }
        }

        [TestMethod]
        public void DecreasingMinElementTest()
        {
            int[][] actual = new int[4][];
            actual[0] = new int[] { 1, 2, 5, 6 }; //14
            actual[1] = new int[] { 5, 7, 9, 17, 19 }; //57
            actual[2] = new int[] { 23, 8, 9 };//40
            actual[3] = new int[] { 1, 2, 0, 6 };//9

            int[][] execute = new int[4][];
            execute[3] = new int[] { 1, 2, 0, 6 };
            execute[2] = new int[] { 1, 2, 5, 6 };
            execute[0] = new int[] { 23, 8, 9 };
            execute[1] = new int[] { 5, 7, 9, 17, 19 };

            actual.BubbleSort(new DecreasingMinElement());

            for (int i = 0; i < execute.Length; i++)
            {
                CollectionAssert.AreEqual(actual[i], execute[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullActualArray()
        {
            int[][] actual = null;

            actual.BubbleSort(new DecreasingMinElement());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullComparerDelegate()
        {
            int[][] actual = new int[4][];
            actual[0] = new int[] { 1, 2, 5, 6 }; //14
            actual[1] = new int[] { 5, 7, 9, 17, 19 }; //57
            actual[2] = new int[] { 23, 8, 9 };//40
            actual[3] = new int[] { 1, 2, 0, 6 };//9

            Comparison<int[]> del = null;
            actual.BubbleSort(del);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullComparerInterface()
        {
            int[][] actual = new int[4][];
            actual[0] = new int[] { 1, 2, 5, 6 }; //14
            actual[1] = new int[] { 5, 7, 9, 17, 19 }; //57
            actual[2] = new int[] { 23, 8, 9 };//40
            actual[3] = new int[] { 1, 2, 0, 6 };//9

            DecreasingMaxElement dec = null;
            actual.BubbleSort(dec);
        }

        [TestMethod]
        public void IncreasingMaxElementTestClosureInterface()
        {
            int[][] actual = new int[4][];
            actual[0] = new int[] { 1, 2, 5, 6 }; //6
            actual[1] = new int[] { 5, 7, 9, 17, 19 }; //19
            actual[2] = new int[] { 23, 8, 9 };//23
            actual[3] = new int[] { 1, 2, 0, 5 };//5

            int[][] execute = new int[4][];
            execute[0] = new int[] { 1, 2, 0, 5 };
            execute[1] = new int[] { 1, 2, 5, 6 };
            execute[3] = new int[] { 23, 8, 9 };
            execute[2] = new int[] { 5, 7, 9, 17, 19 };

            actual.ClosureDelegateBubbleSort(new IncreasingMaxElement());

            for (int i = 0; i < execute.Length; i++)
            {
                CollectionAssert.AreEqual(actual[i], execute[i]);
            }
        }

        [TestMethod]
        public void IncreasingMaxElementTestClosureDelegate()
        {
            int[][] actual = new int[4][];
            actual[0] = new int[] { 1, 2, 5, 6 }; //6
            actual[1] = new int[] { 5, 7, 9, 17, 19 }; //19
            actual[2] = new int[] { 23, 8, 9 };//23
            actual[3] = new int[] { 1, 2, 0, 5 };//5

            int[][] execute = new int[4][];
            execute[0] = new int[] { 1, 2, 0, 5 };
            execute[1] = new int[] { 1, 2, 5, 6 };
            execute[3] = new int[] { 23, 8, 9 };
            execute[2] = new int[] { 5, 7, 9, 17, 19 };

            int Comparison(int[] lhs, int[] rhs) => new IncreasingMaxElement().Compare(lhs, rhs);

            actual.ClosureInterfaceBubbleSort(Comparison);

            for (int i = 0; i < execute.Length; i++)
            {
                CollectionAssert.AreEqual(actual[i], execute[i]);
            }
        }
    }
}
