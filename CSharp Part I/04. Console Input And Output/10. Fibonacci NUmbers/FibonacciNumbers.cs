namespace _10.Fibonacci_NUmbers
{
    using System;
    using System.Collections.Generic;

    public class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 1;
            int sum;
            List<int> fibonacciNumbers = new List<int>();
            fibonacciNumbers.Add(firstNumber);
            fibonacciNumbers.Add(secondNumber);

            if (n == 1 || n == 2)
                {
                    Console.WriteLine(0);
                }
                else
                {
            {
                if(n == 1)
                    Console.WriteLine(string.Join(", ", fibonacciNumbers));
                }
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    sum = firstNumber + secondNumber;
                    fibonacciNumbers.Add(sum);
                    firstNumber = secondNumber;
                    secondNumber = sum;
                }
                Console.WriteLine(string.Join(", ", fibonacciNumbers));
            }
        }
    }
}
