namespace _01.Bitshift_Matrix
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class BitshiftMatrix
    {
        static void Main()
        {
            // input
            int rowsCount = int.Parse(Console.ReadLine());
            int colsCount = int.Parse(Console.ReadLine());
            int moves = int.Parse(Console.ReadLine());
            var coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var matrix = new bool[rowsCount, colsCount];
            int row = rowsCount - 1;
            int col = 0;
            BigInteger currentCellValue = 1;
            int coeff = Math.Max(rowsCount, colsCount);
            BigInteger result = 0;

            foreach (var move in coordinates)
            {
                var nextRow = move / coeff;
                var nextCol = move % coeff;

                var delta = col  > nextCol ? -1 : 1;
                var deltaRow = row > nextRow ? -1 : 1;

                while (col != nextCol)
                {

                    if (!matrix[row, col])
                    {
                        result += currentCellValue;
                        matrix[row, col] = true;
                    }

                    if (delta == 1)
                    {
                        currentCellValue *= 2;
                    }
                    else
                    {
                        currentCellValue /= 2;
                    }

                    col += delta;
                }

                while (row != nextRow)
                {
                    if (!matrix[row, col])
                    {
                        result += currentCellValue;
                        matrix[row, col] = true;
                    }

                    if (deltaRow == 1)
                    {
                        currentCellValue /= 2;
                    }
                    else
                    {
                        currentCellValue *= 2;
                    }


                    row += deltaRow;
                }
            }

            if (!matrix[row, col])
            {

                result += currentCellValue;
                matrix[row, col] = true;
            }
            Console.WriteLine(result);
        }
    }
}
