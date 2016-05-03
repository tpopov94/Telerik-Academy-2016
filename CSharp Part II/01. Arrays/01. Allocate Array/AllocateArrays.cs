/*
Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and
prints the obtained array on the console.
*/
namespace _01.Allocate_Array
{
    using System;

    public class AllocateArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[n];

            for (int index = 0; index <  arrayOfNumbers.Length; index++)
            {
                Console.WriteLine(index * 5);
            }
        }
    }
}
