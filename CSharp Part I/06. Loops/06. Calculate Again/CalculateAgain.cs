/*  Write a program that calculates N! / K! for given N and K.
    Use only one loop.
*/

namespace _06.Calculate_Again
{
    using System;

    public class CalculateAgain
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double result = 1;

            while (n - k >= 1)
            {
                result *= n;
                n--;
            }
            Console.WriteLine(result);
        }
    }
}
