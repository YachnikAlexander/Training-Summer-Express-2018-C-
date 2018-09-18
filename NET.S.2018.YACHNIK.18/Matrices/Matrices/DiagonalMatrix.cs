using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    public class DiagonalMatrix<T> : IMatrix<T> 
                           where T : IEquatable<T>
    {
        private T[] matrix;
        public int Dimension { get; private set; }

        public DiagonalMatrix(T[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            matrix = arr;
        }

        public DiagonalMatrix(T[,] mtx)
        {
            if(mtx == null)
            {
                throw new ArgumentNullException(nameof(mtx));
            }

            matrix = new T[mtx.Length];

            for(int i = 0; i < mtx.Length; i++)
            {
                for(int j = i; j < mtx.Length; j++)
                {
                    if(i == j)
                    {
                        matrix[i] = mtx[i, j];
                        break;
                    }
                }
            }
        }

        public T[,] GetMatrix()
        {
            T[,] mtx = new T[Dimension, Dimension];

            for(int i = 0; i < Dimension; i++)
            {
                for(int j = 0; j < Dimension; j++)
                {
                    if(i == j)
                    {
                        mtx[i, j] = matrix[i];
                    }
                    else
                    {
                        mtx[i, j] = default(T);
                    }
                }
            }

            return mtx;
        }

        public bool IsEqual(T[,] mtx)
        {
            T[,] diagMtx = this.GetMatrix();
            bool check = true;
            for(int i = 0; i < diagMtx.Length; i++)
            {
                for(int j = 0; j < diagMtx.Length; j++)
                {
                    if(!diagMtx[i,j].Equals(mtx[i,j]))
                    {
                        check = false;
                        break;
                    }
                }
            }
            return check;
        }

        public static DiagonalMatrix<T> operator +(DiagonalMatrix<T> lhs, DiagonalMatrix<T> rhs)
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
            return new DiagonalMatrix<T>(lhsMtx);
        }

        public static SymmetricMatrix<T> operator +(DiagonalMatrix<T> lhs, SymmetricMatrix<T> rhs)
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

            return new SymmetricMatrix<T>(lhsMtx, (int)Math.Sqrt(lhsMtx.Length));
        }
    }
}
