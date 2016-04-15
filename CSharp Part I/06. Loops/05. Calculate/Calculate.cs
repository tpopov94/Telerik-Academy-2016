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
            double x = double.Parse(Console.ReadLine());
            double result = 0;
            double factorial = 1;
            double power = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                power = Math.Pow(x, i);

                result += factorial / power;
            }

            Console.WriteLine("{0:F5}", result + 1);
        }
    }
}


