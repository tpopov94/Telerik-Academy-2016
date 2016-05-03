/*

*/
namespace _07.Selection_Sort
{
    using System;

    public class SelectionSort
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new int[n];
            int minValue, minIndex, temp;

            for (int i = 0; i < n; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                minValue = arrayOfNumbers[i];
                minIndex = i;

                for (int j = i; j < n; j++)
                {
                    if (arrayOfNumbers[j] <= minValue)
                    {
                        minValue = arrayOfNumbers[j];
                        minIndex = j;
                    }
                }
                temp = arrayOfNumbers[i];
                arrayOfNumbers[i] = minValue;
                arrayOfNumbers[minIndex] = temp;
            }

            // Result

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arrayOfNumbers[i]);
            }
        }
    }
}
