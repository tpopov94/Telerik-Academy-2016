namespace Matrix_8_10
{
    using System;

    class MatrixMain
    {
        static void Main()
        {
            // First Matrix 
            int row = 4, col = 4;
            var matrixOne = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrixOne[r, c] = r + c; 
                }
            }

            Console.WriteLine("Matrix One:");
            Console.WriteLine(matrixOne.ToString());

            // Second Matrix
            row = 4; col = 4;
            var matrixTwo = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrixTwo[r, c] = (r + c) + 2;
                }
            }

            Console.WriteLine("Matrix Two:");
            Console.WriteLine(matrixTwo.ToString());

            Console.WriteLine("Matrix One + Matrix Two:");  // Task 10
            Console.WriteLine(matrixOne + matrixTwo);
            Console.WriteLine("Matrix One - Matrix Two:");  // Task 10
            Console.WriteLine(matrixOne - matrixTwo);
            Console.WriteLine("Matrix One * Matrix Two:");  // Task 10
            Console.WriteLine(matrixOne * matrixTwo);

            // Checking the True and False Methods in matrix.cs
            // If there is zero in the matrix the result is False
            if (matrixTwo)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
