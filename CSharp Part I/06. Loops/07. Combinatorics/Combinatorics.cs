/*
n combinatorics, the number of ways to choose N different members 
out of a group of N different elements (also known as the number of combinations) is calculated 
by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.

    Try to use only two loops.
*/

namespace _07.Combinatorics
{
    using System;
    using System.Numerics;

    public class Combinatorics
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger nkFactorial = 1;
            BigInteger result = 0;

            for (int i = 1; i < n + 1; i++)
            {
                nFactorial *= i;

                if (i <= k)
                {
                    kFactorial *= i;
                }
            }

            for (int nk = n - k; nk > 1; nk--)
            {
                nkFactorial *= nk;
            }

            result = (nFactorial / (kFactorial * nkFactorial));
            Console.WriteLine(result);
        }
    }
}