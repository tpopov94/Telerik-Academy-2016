/*
You are given N integers (given in a single line, separated by a space).
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to N, so the first element is odd, the second is even, etc.
*/

/*namespace _10.Odd_And_Even_Product
{
    using System;

    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var arrayOfNumbers = input.Split(' ');
            int oddSum = 1;
            int evenSum = 1;

            for (int i = 1; i < arrayOfNumbers.Length + 1 ; i++)
            {
                if (i % 2 != 0)
                {
                    oddSum *= int.Parse(arrayOfNumbers[i - 1]);
                }
                else
                {
                    evenSum *= int.Parse(arrayOfNumbers[i - 1]);
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("yes {0}", evenSum);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddSum, evenSum);
            }
        }
    }
}
*/
//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class OddEvenProduct
{
    static void Main(string[] args)
    {

        string input = Console.ReadLine();
        int count = 0;
        long productOdd = 1;
        long productEven = 1;
        string number = "";
        for (int i = 0; i < input.Length; i++)
        {
            number = "";
            while (input[i] != ' ' && i < input.Length)
            {
                number += input[i];
                if (i < input.Length - 1)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            count++;
            if (count % 2 == 0)
            {
                productEven *= int.Parse(number);
            }
            else
            {
                productOdd *= int.Parse(number);
            }
        }
        if (productEven == productOdd)
        {
            Console.WriteLine("yes {0}", productEven);
        }
        else
        {
            Console.WriteLine("no {0} {1}", productOdd, productEven);
        }
    }
}