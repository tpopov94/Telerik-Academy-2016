// Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.) Use generic method (read in Internet about generic methods in C#).
namespace _15.Number_Calculations
{
    using System;
    using System.Linq;

    public class NumberCalculations
    {
        static void Main()
        {
            int[] arrayOfInts = { 1, 34, 432, 2, 1 };
            Console.WriteLine(Min(arrayOfInts)); 
            Console.WriteLine(Max(arrayOfInts));
            Console.WriteLine("{0:f2}", Average(arrayOfInts));
            Console.WriteLine(Sum(arrayOfInts));
            Console.WriteLine(Product(arrayOfInts));

            Console.WriteLine(new string('-', 20));

            // doubles

            double[] arrayOfDoubles = { 1.1, 34.2, 432.31, -2.4, -1.2 };
            Console.WriteLine(Min(arrayOfDoubles));
            Console.WriteLine(Max(arrayOfDoubles));
            Console.WriteLine("{0:f2}", Average(arrayOfDoubles));
            Console.WriteLine(Sum(arrayOfDoubles));
            Console.WriteLine(Product(arrayOfDoubles));

        }

        static T Min<T>(params T[] array)
        {
            return array.Min();
        }
        static T Max<T>(params T[] array)
        {
            return array.Max();
        }
        static double Average<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / (double)array.Length;
        }
        static T Sum<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }
        static T Product<T>(params T[] array)
        {
            dynamic product = 1;
            foreach (var item in array)
            {
                product *= item;
            }
            return product;
        }
    }
}
