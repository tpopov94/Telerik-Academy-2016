// Write a program that finds the maximal sum of consecutive elements 
// in a given array of N numbers.
namespace _08.Max_Sum
{
    using System;

    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new int[n];
            long maxSum = arrayOfNumbers[0];
            long currentSum = arrayOfNumbers[0];

            for (int i = 0; i < n; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] == 0)
                {
                    continue;
                }
                if ((currentSum + arrayOfNumbers[i] > currentSum) || (arrayOfNumbers[i - 1] >= arrayOfNumbers[i]))
                {
                    currentSum += arrayOfNumbers[i];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
                else
                {
                    i++;
                    currentSum = arrayOfNumbers[i];
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
