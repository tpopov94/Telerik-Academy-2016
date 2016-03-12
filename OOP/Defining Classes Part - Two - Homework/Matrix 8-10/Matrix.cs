using System;
using System.Text;

namespace Matrix_8_10
{
    public class Matrix<T> where T : IComparable<T>
    {
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
        }

        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.matrix.GetLength(0) != matrixTwo.matrix.GetLength(0) ||
            matrixOne.matrix.GetLength(1) != matrixTwo.matrix.GetLength(1))
            {
                throw new ArgumentException("The two matrices must have same dimensions !");
            }

            var result = new Matrix<T>(matrixOne.matrix.GetLength(0), matrixOne.matrix.GetLength(1));

            for (int row = 0; row < matrixOne.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrixOne.matrix.GetLength(1); col++)
                {
                    result[row, col] = (dynamic)matrixOne[row, col] + (dynamic)matrixTwo[row, col];
                }
            }
            return result;
        }  // Task 10

        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.matrix.GetLength(0) != matrixTwo.matrix.GetLength(0) ||
            matrixOne.matrix.GetLength(1) != matrixTwo.matrix.GetLength(1))
            {
                throw new ArgumentException("The two matrices must have same dimensions !");
            }

            var result = new Matrix<T>(matrixOne.matrix.GetLength(0), matrixOne.matrix.GetLength(1));

            for (int row = 0; row < matrixOne.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrixOne.matrix.GetLength(1); col++)
                {
                    T max = matrixOne[row, col];
                    T min = matrixTwo[row, col];

                    if ((dynamic)matrixOne[row, col] < (dynamic)matrixTwo[row, col])
                    {
                        max = matrixTwo[row, col];
                        min = matrixOne[row, col];
                    }
                    result[row, col] = (dynamic)max - (dynamic)min;
                }
            }
            return result;
        }  // Task 10

        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.matrix.GetLength(1) != matrixTwo.matrix.GetLength(0))
            {
                throw new ArgumentException("The two matrices must have same dimensions !");
            }

            var result = new Matrix<T>(matrixOne.matrix.GetLength(0), matrixTwo.matrix.GetLength(1));

            for (int row = 0; row < result.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < result.matrix.GetLength(1); col++)
                {
                    for (int i = 0; i < matrixOne.matrix.GetLength(1); i++)
                    {
                        result[row, col] += (dynamic)matrixOne[row, i] * (dynamic)matrixTwo[i, col];
                    }
                }
            }
            return result;
        }  // Task 10

        public static bool operator true(Matrix<T> matrix)
        {
            bool isTrue = true;

            for (int row = 0; row < matrix.matrix.GetLength(0) && isTrue; row++)
            {
                for (int col = 0; col < matrix.matrix.GetLength(1) && isTrue; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        isTrue = false;
                    }
                }
            }

            return isTrue;
        }   // Task 10

        public static bool operator false(Matrix<T> matrix)
        {
            bool isTrue = true;

            for (int row = 0; row < matrix.matrix.GetLength(0) && isTrue; row++)
            {
                for (int col = 0; col < matrix.matrix.GetLength(1) && isTrue; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        isTrue = false;
                    }
                }
            }
            return !isTrue;
        }       // Task 10

        public static bool operator !(Matrix<T> matrix)
        {
            if (matrix)
            {
                return false;
            }
            return true;
        }       // Task 10

        public override string ToString()
        {
            StringBuilder matrixResult = new StringBuilder();

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    matrixResult.AppendFormat("{0:D2} ", this.matrix[row, col]);
                }
                matrixResult.Append("\n");
            }

            return matrixResult.ToString();
        }
    }
}
