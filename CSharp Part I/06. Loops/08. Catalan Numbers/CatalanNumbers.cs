/*
In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    Write a program to calculate the Nth Catalan number by given N
*/

namespace _08.Catalan_Numbers
{
    using System;
    using System.Numerics;

    public class CatalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result;

            result = (Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n));
            Console.WriteLine(result);
        }

        public static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = n; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
