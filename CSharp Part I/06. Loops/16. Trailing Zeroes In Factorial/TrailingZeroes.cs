/*Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
    Your program should work well for very big numbers, e.g. N = 100000.
*/

namespace _16.Trailing_Zeroes_In_Factorial
{
    using System;

    public class TrailingZeroes
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int count = 1;
            int zeroes = 0;

            while (input / Math.Pow(5, count) >= 1)
            {
                zeroes += input / (int)(Math.Pow(5, count));
                count++;
            }
            Console.WriteLine(zeroes);
        }
    }
}