/* Write a program that reads two integer arrays of size N from the console
and compares them element by element.
*/
namespace _02.Compare_Arrays
{
    using System;

    public class CompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            string result = string.Empty;

            // Allocating Arrays
            for (int index = 0; index < n; index++)
            {
                firstArray[index] = int.Parse(Console.ReadLine());
            }

            for (int index = 0; index < n; index++)
            {
                secondArray[index] = int.Parse(Console.ReadLine());
            }

            result = ArrayComparer(firstArray, secondArray, n);
            Console.WriteLine(result);
        }

        public static string ArrayComparer(int[] firstArray, int[] secondArray, int n)
        {
            for (int index = 0; index < n; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    return "Not equal";
                }
            }
            return "Equal";
        }
    }
}
