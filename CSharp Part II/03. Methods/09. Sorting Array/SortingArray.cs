
namespace _09.Sorting_Array
{
    using System;
    using System.Linq;

    class SortingArray
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            //decimal[] arrayOfNumbers = { 3, 4, 1, 5, 2, 6 };
            decimal[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(s => decimal.Parse(s)).ToArray();
            SortArray(arrayOfNumbers);
            Console.WriteLine(string.Join(" ",arrayOfNumbers));
        }

        static void SortArray(decimal[] array)
        {
           Array.Sort(array);
        }
    }
}
