/*
Write a program that reads two integer numbers N and K and an array of N elements from the console. 
Find the maximal sum of K elements in the array.
*/
namespace _06.Maximal_K_Sum
{
    using System;

    public class MaximalKSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new int[n];
            int bestSum = 0;
            int maxNumber = int.MinValue;
            int maxNumIndex = 0;

            for (int index = 0; index < n; index++)
            {
                arrayOfNumbers[index] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arrayOfNumbers[j] >= maxNumber)
                    {
                        maxNumber = arrayOfNumbers[j];
                        maxNumIndex = j;
                    }
                }
                bestSum += maxNumber;
                maxNumber = int.MinValue;
                arrayOfNumbers[maxNumIndex] = int.MinValue;
            }

            Console.WriteLine(bestSum);
        }
    }
}
