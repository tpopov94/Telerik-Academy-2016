// Write a program that generates and prints to the console 10 random values in the range [100, 200].
namespace _02.Random_Numbers
{
    using System;
    using System.Collections.Generic;

    public class RandomNumbers
    {
        static void Main()
        {
            var listOfRandomNumbers = RandomGenerator();

            Console.WriteLine(string.Join(", ", listOfRandomNumbers));
            
        }

        public static List<int> RandomGenerator()
        {
            var listOfNumbers = new List<int>();
            Random generator = new Random();

            for (int i = 0; i < 9; i++)
            {
                listOfNumbers.Add(generator.Next(100, 201));
            }

            return listOfNumbers;
        }
    }
}
