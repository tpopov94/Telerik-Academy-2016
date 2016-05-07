//Write a method GetMax() with two parameters that returns the larger of two integers. 
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

namespace _02.Get_Largest_Number
{
    using System;
    using System.Linq;

    public class GetLargestNumber
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine(GetMax(input[0], GetMax(input[1], input[2])));
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            int maxNumber = firstNumber;
            if (secondNumber > firstNumber)
            {
                maxNumber = secondNumber;
            }

            return maxNumber;
        }
    }
}
