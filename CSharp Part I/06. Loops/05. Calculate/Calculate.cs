// Write a program that, for a given two integer numbers n and x, calculates the sum 
// S = 1 + 1!/x + 2!/x2 + … + n!/x^n.

namespace _05.Calculate
{
    using System;

    public class Calculate
    {
        static void Main()
        {
            double result = 1;
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                result += Factorial(i) / Power(x, i);
            }

            Console.WriteLine("{0:F5}", result);
        }

        public static double Factorial(double number)
        {
            double factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static double Power(double number, int power)
        {
            double result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
