namespace _02.Maximal_Sum
{
    using System;
    using System.Linq;

    public class MaximalSum
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] rowsAndColsArray = input.Split(' ').Select(n => int.Parse(n)).ToArray();
            int rows = rowsAndColsArray[0];
            int cols = rowsAndColsArray[0];
        
            int[,] numbersArray = new int[rows, cols];

            //Initiating Array
            for (int row = 0; row < rows; row++)
            {
                var colArray = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    numbersArray[row, col] = colArray[col];
                }
            }

            // Task Solution

            long maxSum = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    long currentSum = 0;
                    currentSum += numbersArray[row, col] + numbersArray[row, col + 1] + numbersArray[row, col + 2]
                        + numbersArray[row + 1, col] + numbersArray[row + 1, col + 1] + numbersArray[row + 1, col + 2]
                        + numbersArray[row + 2, col] + numbersArray[row + 2, col + 1] + numbersArray[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
