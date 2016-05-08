/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments. 
Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.*/
namespace _14.Integer_Calculations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerCalculations
    {
        static void Main()
        {
            int[] arrayOfInts = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            Console.WriteLine(Min(arrayOfInts));
            Console.WriteLine(Max(arrayOfInts));
            Console.WriteLine("{0:f2}", Average(arrayOfInts));
            Console.WriteLine(Sum(arrayOfInts));
            Console.WriteLine(Product(arrayOfInts));
        }

        static int Min(params int[] array)
        {
            return array.Min();
        }
        static int Max(params int[] array)
        {
            return array.Max();
        }
        static double Average(params int[] array)
        {
            List<int> list = array.ToList();
            return list.Average();
        }
        static long Sum(params int[] array)
        {
            return array.Sum();
        }
        static long Product(params int[] array)
        {
            long product = 1;
            foreach (var item in array)
            {
                product *= item;
            }
            return product;
        }
    }
}
