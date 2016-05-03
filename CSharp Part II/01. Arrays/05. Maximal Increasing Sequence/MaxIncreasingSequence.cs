// Write a program that finds the length of the maximal increasing sequence in an array of N integers.
namespace _05.Maximal_Increasing_Sequence
{
    using System;

    public class MaxIncreasingSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int bestSequence = 0;
            int curBest = 1;
            /*int[] arrayOfNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }
            */
            int[] arrayOfNumbers = { 7, 1, 2, 3, 4, 5, 6, 4, 2, 1 };

            for (int i = 0; i < n-1; i++)
            {
                if (arrayOfNumbers[i] < arrayOfNumbers[i+1])
                {
                    curBest++;
                }
                else
                {
                    if (curBest > bestSequence)
                    {
                        bestSequence = curBest;
                    }
                    curBest = 1;
                }
            }

            Console.WriteLine(bestSequence);
        }
    }
}
