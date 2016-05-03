/*
Write a program that sorts an array of integers using the Merge sort algorithm
*/
namespace _13.Merge_Sort
{
    using System;

    public class MegeSort
    {
        public static int[] SplitArray(int[] arrayOfNumbers)
        {
            if (arrayOfNumbers.Length == 1)
            {
                return arrayOfNumbers;
            }

            int middle = arrayOfNumbers.Length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[arrayOfNumbers.Length - middle];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (i < middle)
                {
                    leftArray[i] = arrayOfNumbers[i];
                }
                else
                {
                    rightArray[i - middle] = arrayOfNumbers[i];
                }
            }

            leftArray = SplitArray(leftArray);
            rightArray = SplitArray(rightArray);

            return MergeArrays(leftArray, rightArray);
        }

        public static int[] MergeArrays(int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int[] array = new int[left.Length + right.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (rightIndex == right.Length
                    || (leftIndex < left.Length
                    && left[leftIndex] <= right[rightIndex]))
                {
                    array[i] = left[leftIndex];
                    leftIndex++;
                }
                else if (leftIndex == left.Length
                    || (rightIndex < right.Length
                    && left[leftIndex] >= right[rightIndex]))
                {
                    array[i] = right[rightIndex];
                    rightIndex++;
                }
            }

            return array;
        }

        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            arrayOfNumbers = SplitArray(arrayOfNumbers);

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(arrayOfNumbers[i]);
            }
        }
    }
}
