namespace _02.Lover_Of_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
 // using System.Numerics;

    public class LoverOfThree
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowsCount = input[0];
            int colsCount = input[1];
            int n = int.Parse(Console.ReadLine());
            long result = 0;

            var matrix = new bool[rowsCount, colsCount];

            int row = rowsCount - 1;
            int col = 0;

            for (int i = 0; i < n; i++)
            {
                var move = Console.ReadLine().Split(' ');
                string direction = move[0];
                int repeats = int.Parse(move[1]);

                int deltaRow = direction.Contains("U") ? -1 : 1;
                int deltaCol = direction.Contains("L") ? -1 : 1;

                for (int j = 0; j < repeats - 1; j++)
                {
                    if (IsInside(row + deltaRow, col + deltaCol, matrix))
                    {
                        row += deltaRow;
                        col += deltaCol;

                        // If value is not collected
                        if (!matrix[row,col])
                        {
                            result += col * 3 + (rowsCount - 1 - row) * 3;
                            matrix[row, col] = true;
                        }
                    }
                    else
                    {
                        // when we reach out of the border of the matrix
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }

        static bool IsInside(int row, int col, bool[,] matrix)
        {
            bool isRowInMatrix = (0 <= row) && (row < matrix.GetLength(0));
            bool isColInMatrix = (0 <= col) && (col < matrix.GetLength(1));

            return isRowInMatrix && isColInMatrix;
        }
    }
}
