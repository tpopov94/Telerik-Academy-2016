//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours(when such exist).
//Write program that reads an array of numbers and prints how many of them are larger than their neighbours.
namespace _05.Larger_Than_Neighbours
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargerThanNeighbours
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbersList = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            Console.WriteLine(LargerThanNeighboursInList(numbersList));
        }

        static int LargerThanNeighboursInList(List<int> numbersList)
        {
            int count = 0;

            for (int i = 1; i < numbersList.Count - 1; i++)
            {
                int currentNumber = numbersList[i];

                if (numbersList[i-1] < currentNumber && currentNumber > numbersList[i+1])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
