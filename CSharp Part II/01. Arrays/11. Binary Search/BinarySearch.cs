/*
Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm
*/
namespace _11.Binary_Search
{
    using System;

    public class BinarySearch
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            int searchNumber = int.Parse(Console.ReadLine());
            int left = 0;
            int right = arrayOfNumbers.Length - 1;
            int middle = (left + right) / 2;
            bool findNumber = false;                         //checks if there is such number in the array

            while (left <= right)
            {
                middle = (left + right) / 2;                     // here we find the middle position in the array
                if (searchNumber == arrayOfNumbers[middle])        // if the searched number has the middle index in the array we break and print the result
                {
                    findNumber = true;
                    break;
                }
                else if (searchNumber < arrayOfNumbers[middle])     // if the searched number is smaller than the number in the array with [middle] index
                {
                    right = middle - 1;                           // the right border of our search becomes middle - 1 
                }                                                 //(because the array is sorted and we dont have to search in the numbers that are bigger than the middle one)
                else
                {
                    left = middle + 1;                            //if the searched number is bigger than the number in the array with [middle] index, left border becomes middle + 1 
                }
            }
            // result
            if (findNumber)
            {
                Console.WriteLine(middle);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
