namespace _05.Maximal_Increasing_Sequence
{
    using System;

    public class MaxIncreasingSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            int bestSequnece = 1;
            int curBest = 1;
            int firstElement = arrayOfNumbers[0];

            for (int i = 1; i < n; i++)
            {
                if (arrayOfNumbers[i] > firstElement)
                {
                    curBest++;
                }
                else
                {
                    if (curBest > bestSequnece)
                    {
                        bestSequnece = curBest;
                    }
                    curBest = 1;
                    firstElement = arrayOfNumbers[i];
                }
            }

            if (curBest > bestSequnece)
            {
                bestSequnece = curBest;
            }

            Console.WriteLine(bestSequnece);
        }
    }
}