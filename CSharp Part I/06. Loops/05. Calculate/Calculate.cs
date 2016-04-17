// Write a program that, for a given two integer numbers n and x, calculates the sum 
// S = 1 + 1!/x + 2!/x2 + … + n!/x^n.

namespace _05.Calculate
{
    using System;

    public class Calculate
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal x = decimal.Parse(Console.ReadLine());
            decimal result = 0;
            decimal factorial = 1;
            decimal power = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                power = Power(x, i);

                result += factorial / power;
            }

            Console.WriteLine("{0:F5}", result + 1);
        }

        public static decimal Power(decimal x, decimal power)
        {
            decimal result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}


