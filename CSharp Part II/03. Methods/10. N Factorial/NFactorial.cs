namespace _10.N_Factorial
{
    using System;

    public class NFactorial
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(number));
        }

        static decimal Factorial(int number)
        {
            decimal result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
