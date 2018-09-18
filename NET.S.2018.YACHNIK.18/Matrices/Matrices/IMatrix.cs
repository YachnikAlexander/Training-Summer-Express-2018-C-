using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    public interface IMatrix<T>
    {
        int Dimension { get; }
        T[,] GetMatrix();
        bool IsEqual(T[,] mtx); 
    }
}
