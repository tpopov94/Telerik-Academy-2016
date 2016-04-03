// Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.

namespace _06.BiggestOfFive
{
    using System;
    using System.Collections.Generic;

    public class BiggestOfFive
    {
        static void Main()
        {
            List<double> numbers = new List<double>();

            for (int i = 0; i < 5; i++)
            {
                numbers.Add(double.Parse(Console.ReadLine()));
            }
            double max = numbers[0];

            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine(max);
        }
    }
}
