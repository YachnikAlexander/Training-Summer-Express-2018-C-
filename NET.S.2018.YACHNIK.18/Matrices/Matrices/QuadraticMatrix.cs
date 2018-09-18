using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    public class QuadraticMatrix<T> : IMatrix<T>
                            where T : IEquatable<T>
    {
        private T[,] matrix;
        public int Dimension { get; private set; }

        public QuadraticMatrix(T[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            this.matrix = matrix;
            Dimension = (int)Math.Sqrt(matrix.Length);
        }

        public T[,] GetMatrix()
        {
            return this.matrix;
        }

        public bool IsEqual(T[,] mtx)
        {
            T[,] matrix = this.GetMatrix();
            bool check = true;
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    if (!matrix[i, j].Equals(mtx[i, j]))
                    {
                        check = false;
                        break;
                    }
                }
            }
            return check;
        }

        public static QuadraticMatrix<T> operator+ (QuadraticMatrix<T> lhs, QuadraticMatrix<T> rhs)
        {
            T[,] lhsMtx = lhs.GetMatrix();
            T[,] rhsMtx = rhs.GetMatrix();

            for (int i = 0; i < lhs.Dimension; i++)
            {
                for(int j = 0; j < lhs.Dimension; j++)
                {
                    lhsMtx[i, j] += (dynamic)lhsMtx[i, j]+ (dynamic)rhsMtx[i, j];
                }
            }
            return new QuadraticMatrix<T>(lhsMtx);
        }

        public static QuadraticMatrix<T> operator +(QuadraticMatrix<T> lhs, SymmetricMatrix<T> rhs)
        {
            T[,] lhsMtx = lhs.GetMatrix();
            T[,] rhsMtx = rhs.GetMatrix();

            for (int i = 0; i < lhs.Dimension; i++)
            {
                for (int j = 0; j < lhs.Dimension; j++)
                {
                    lhsMtx[i, j] += (dynamic)lhsMtx[i, j] + (dynamic)rhsMtx[i, j];
                }
            }
            return new QuadraticMatrix<T>(lhsMtx);
        }

        public static QuadraticMatrix<T> operator +(QuadraticMatrix<T> lhs, DiagonalMatrix<T> rhs)
        {
            T[,] lhsMtx = lhs.GetMatrix();
            T[,] rhsMtx = rhs.GetMatrix();

            for (int i = 0; i < lhs.Dimension; i++)
            {
                for (int j = 0; j < lhs.Dimension; j++)
                {
                    lhsMtx[i, j] += (dynamic)lhsMtx[i, j] + (dynamic)rhsMtx[i, j];
                }
            }
            return new QuadraticMatrix<T>(lhsMtx);
        }

    }
}
