//Write a program that finds in given array of integers a sequence of given sum S(if present).
namespace _10.Find_Sum_In_Array
{
    using System;

    public class FindSumInArray
    {
        static void Main()
        {
            var arrayOfNumbers = new int[] { 4, 3, 1, 4, 2, 5, 8 };
            int s = 11;
            int curSum = 0;
            int startIndex = 0;
            int endIndex = 0;
            bool flag = false;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                startIndex = i;
                for (int j = i; j < arrayOfNumbers.Length; j++)
                {
                    curSum += arrayOfNumbers[j];
                    if (curSum == s)
                    {
                        endIndex = j;
                        flag = true;
                        break;
                    }
                    if (curSum > s)
                    {
                        curSum = 0;
                    }
                }
                if (flag)
                {
                    break;
                }
            }

            if (flag)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    Console.WriteLine(arrayOfNumbers[i]);
                }
            }
            else
            {
                Console.WriteLine("There is no sequence of elements in the array that give the sum {0}", s);
            }
        }
    }
}
