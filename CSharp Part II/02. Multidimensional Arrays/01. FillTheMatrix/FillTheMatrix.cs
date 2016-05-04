namespace _01.FillTheMatrix
{
    using System;

    public class FillTheMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string typeOfMatrix = Console.ReadLine();
            int[,] resultMatrix = new int[n, n];

            switch (typeOfMatrix)
            {
                case "a":
                    resultMatrix = MatrixTypeA(n);
                    break;
                case "b":
                    resultMatrix = MatrixTypeB(n);
                    break;
                case "c":
                    resultMatrix = MatrixTypeC(n);
                    break;
                case "d":
                    resultMatrix = MatrixTypeD(n);
                    break;
            }

            // Printing the Matrix
            PrintMatrix(resultMatrix, n);
        }

        // Matrix type A
        public static int[,] MatrixTypeA(int n)
        {
            int[,] resultMatrix = new int[n, n];
            int index = 1;

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    resultMatrix[col, row] = index;
                    index++;
                }
            }
            return resultMatrix;
        }

        // Matrix type B
        public static int[,] MatrixTypeB(int n)
        {
            var resultMatrix = new int[n, n];
            int index = 1;

            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        resultMatrix[col, row] = index;
                        index++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        resultMatrix[col, row] = index;
                        index++;
                    }
                }
               
            }
            return resultMatrix;
        }

        // Matrix type C
        public static int[,] MatrixTypeC(int n)
        {
            int[,] resultMatrix = new int[n, n];
            int startRow = n - 1;
            int startCol = 0;
            int currentNumber = 1;
            int currentRow, currentCol;

            for (int index = 1; index <= n * 2; index++)
            {
                currentRow = startRow;
                currentCol = startCol;

                while (currentRow <= n - 1 && currentCol <= n - 1)
                {
                    resultMatrix[currentCol, currentRow] = currentNumber;
                    currentRow++;
                    currentCol++;
                    currentNumber++;
                }

                if (startRow > 0)
                {
                    startRow--;
                }
                else
                {
                    startCol++;
                }
            }

            return resultMatrix;
        }

        // Matrix type D
        public static int[,] MatrixTypeD(int n)
        {
            string direction = "right";
            int currentRow = 0;
            int currentCol = 0;
            var resultMatrix = new int[n, n];

            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "right" && (currentCol >= n || resultMatrix[currentRow, currentCol] != 0)) // Check if outside of array or already visited
                {
                    currentCol--;
                    currentRow++;
                    direction = "down";
                }
                else if (direction == "down" && (currentRow >= n || resultMatrix[currentRow, currentCol] != 0)) // Check if outside of array or already visited
                {
                    direction = "left";
                    currentRow--;
                    currentCol--;
                }
                else if (direction == "left" && (currentCol < 0 || resultMatrix[currentRow, currentCol] != 0)) // Check if outside of array or already visited
                {
                    direction = "up";
                    currentCol++;
                    currentRow--;
                }
                else if (direction == "up" && (currentRow < 0 || resultMatrix[currentRow, currentCol] != 0)) // Check if outside of array or already visited
                {
                    direction = "right";
                    currentRow++;
                    currentCol++;
                }

                resultMatrix[currentRow, currentCol] = i;

                if (direction == "right")
                {
                    currentCol++;
                }
                else if (direction == "down")
                {
                    currentRow++;
                }
                else if (direction == "left")
                {
                    currentCol--;
                }
                else if (direction == "up")
                {
                    currentRow--;
                }
            }

            return resultMatrix;
        }

        // Print Matrix
        public static void PrintMatrix(int[,] resultMatrix, int n)
        {
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write("{0}", resultMatrix[row, col]);
                    if (row < n - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
