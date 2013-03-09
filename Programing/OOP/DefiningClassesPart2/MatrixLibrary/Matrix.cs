using System;
using System.Collections.Generic;

namespace MatrixLibrary
{
    public class Matrix<T> : IEnumerable<T> where T : struct, IFormattable
    {
        private T[,] matrix;

        #region Properties
        public int Row { get; private set; }
        public int Col { get; private set; }
        public T this[int row, int col]
        {
            get
            {
                IndexChecker(row, col);
                return this.matrix[row, col];
            }
            set
            {
                IndexChecker(row, col);
                this.matrix[row, col] = value;
            }
        }
        #endregion

        #region Constructors
        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.matrix = new T[row, col];
        }
        #endregion

        #region Private Methods
        private void IndexChecker(int indexRow, int indexCol)
        {
            if ((indexRow < 0 || indexRow >= this.Row) || (indexCol < 0 || indexCol >= this.Col))
            {
                throw new IndexOutOfRangeException("The entered index is out of range!");
            }
        }
        #endregion

        #region Public Methods
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Row != secondMatrix.Row) && (firstMatrix.Col != secondMatrix.Col))
            {
                throw new InvalidOperationException("The matrices cannot be added due to incompatible lengths!");
            }
            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);
            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    newMatrix[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Row != secondMatrix.Row) && (firstMatrix.Col != secondMatrix.Col))
            {
                throw new InvalidOperationException("The matrices cannot be subtracted due to incompatible lengths!");
            }
            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);
            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    newMatrix[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Col != secondMatrix.Row)
            {
                throw new InvalidOperationException("The matrices cannot be multiplied due to incompatible lengths!");
            }
            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Row, secondMatrix.Col);
            for (int row = 0; row < newMatrix.Row; row++)
            {
                for (int col = 0; col < newMatrix.Col; col++)
                {
                    for (int i = 0; i < firstMatrix.Row; i++)
                    {
                        newMatrix[row, col] += (dynamic)firstMatrix[row, i] * secondMatrix[i, col];
                    }
                }
            }
            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            foreach (var item in matrix)
            {
                if (!item.Equals(0))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            foreach (var item in matrix)
            {
                if (!item.Equals(0))
                {
                    return false;
                }
            }
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in this.matrix)
            {
                yield return element;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion
    }
}
