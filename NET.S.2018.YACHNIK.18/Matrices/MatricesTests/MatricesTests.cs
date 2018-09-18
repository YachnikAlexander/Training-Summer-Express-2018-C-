using NUnit.Framework;
using Matrices;

namespace MatricesTests
{
    [TestFixture]
    public class MatricesTests
    {
        private DiagonalMatrix<int> DiagonalMatrix = new Matrices.DiagonalMatrix<int>(new int[3] { 1, 2, 3 });
        private SymmetricMatrix<int> SymmetricMatrix = new SymmetricMatrix<int>(new int[6] { 1, 2, 3, 4, 5, 6 }, 3);
        private QuadraticMatrix<int> QuadMatrix = new QuadraticMatrix<int>(new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });

        private int[,] QuadDiagonalMatrix = new int[3, 3] { { 1, 0, 0 }, { 0, 2, 0 }, { 0, 0, 3 } };
        private int[,] QuadSymmetricMatrix = new int[3, 3] { { 1, 2, 3 }, { 2, 4, 5 }, { 3, 5, 6 } };
        private int[,] QuadNormalMatrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };



        [TestCase(ExpectedResult = true)]

        public bool CheckMatricies()
        {
            //return SymmetricMatrix.IsEqual(QuadSymmetricMatrix);
            return QuadMatrix.IsEqual(QuadNormalMatrix);

        }



    }
}
