/*You are given a sequence of positive integer values written into a string, separated by spaces. 
Write a function that reads these values from given string and calculates their sum. 
Write a program that reads a string of positive integers separated by spaces and prints their sum.*/
namespace _08.Sum_Integers
{
    using System;
    using System.Linq;

    public class SumIntegers
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(SumOfIntegers(input));
        }

        public static long SumOfIntegers(string input)
        {
            long result = 0;
            var arrayOfNumbers = input.Split(' ').Select(n => int.Parse(n)).ToArray();

            foreach (var number in arrayOfNumbers)
            {
                result += number;
            }
            return result;
        }
    }
}
