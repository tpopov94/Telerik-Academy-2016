//Write a method that returns the index of the first element in array that is larger than its neighbours, 
//or -1, if there is no such element.
namespace _06.First_Larger_Than_Neighbours
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FirstLargerThanNeighbours
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbersList = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            Console.WriteLine(FirstLargerThanNeighboursInListIndex(numbersList));
        }

        static int FirstLargerThanNeighboursInListIndex(List<int> numbersList)
        {
            for (int i = 1; i < numbersList.Count - 1; i++)
            {
                int currentNumber = numbersList[i];

                if (numbersList[i - 1] < currentNumber && currentNumber > numbersList[i + 1])
                {
                   return i;
                }
            }

            return -1;
        }
    }
}
