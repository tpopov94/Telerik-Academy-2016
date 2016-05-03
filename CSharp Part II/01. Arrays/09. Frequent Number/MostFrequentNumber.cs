// Write a program that finds the most frequent number in an array of N elements
namespace _09.Frequent_Number
{
    using System;

    public class MostFrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new int[n];
            int mostFreqNumber = 0, currentNumber;
            int currentBestRepeated = 0;
            int bestRepeated = 0;

            for (int i = 0; i < n; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < n; i++)
            {
                currentNumber = arrayOfNumbers[i];

                for (int j = i; j < n; j++)
                {
                    if (currentNumber == arrayOfNumbers[j])
                    {
                        currentBestRepeated++;
                    }
                }

                if (currentBestRepeated > bestRepeated)
                {
                    bestRepeated = currentBestRepeated;
                    mostFreqNumber = currentNumber;
                }
                currentBestRepeated = 1;
            }

            Console.WriteLine("{0} ({1} times)", mostFreqNumber, bestRepeated);
        }
    }
}

