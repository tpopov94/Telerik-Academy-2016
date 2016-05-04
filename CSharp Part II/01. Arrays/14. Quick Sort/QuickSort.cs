namespace _14.Quick_Sort
{
    using System;

    public class QuickSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arrayOfNumbers);

            foreach (var number in arrayOfNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
