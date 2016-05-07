// Write a method that reverses the digits of a given decimal number.
namespace _07.Reverse_Number
{
    using System;

    public class ReverseNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseNumber(input));
        }

        static decimal ReverseNumber(string number)
        {
            string reversedNumber = null;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNumber += number[i];
            }

            return decimal.Parse(reversedNumber);
        }
    }
}
