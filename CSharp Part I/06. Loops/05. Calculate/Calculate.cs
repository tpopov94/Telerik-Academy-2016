// Write a program that, for a given two integer numbers n and x, calculates the sum 
// S = 1 + 1!/x + 2!/x2 + … + n!/x^n.

namespace _05.Calculate
{
    using System;

    public class Calculate
    {
        static void Main()
        {
            decimal result = 1;
            int n = int.Parse(Console.ReadLine());
            decimal x = decimal.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                result += Factorial(i) / Power(x, i);
            }

            Console.WriteLine("{0:F5}", result);
        }

        public static decimal Factorial(decimal number)
        {
            decimal factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static decimal Power(decimal number, int power)
        {
            decimal result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
