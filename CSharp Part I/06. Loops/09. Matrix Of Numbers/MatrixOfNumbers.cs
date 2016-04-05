/*
Write a program that reads from the console a positive integer number N and 
prints a matrix like in the examples below.Use two nested loops.
 */

namespace _09.Matrix_Of_Numbers
{
    using System;

    public class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int limit = n;

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= limit; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                limit++;
            }
        }
    }
}
