/*
Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
    Use the Euclidean algorithm
    The numbers A and B will always be valid integers in the range [2, 500].
*/
namespace _15.GCD
{
    using System;

    public class GCD
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]); ;

            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                Console.WriteLine(b);
            else
                Console.WriteLine(a);
        }
    }
}
