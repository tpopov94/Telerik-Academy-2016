// Write a program that converts a decimal number N to its binary representation.
namespace _01.Decimal_To_Binary
{
    using System;

    public class DecToBIn
    {
        static void Main()
        {
            long decNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(decNumber));
        }

        static string DecimalToBinary(long decNumber)
        {
            string binNumber = string.Empty;
            string reverseNumber = string.Empty;

            if (decNumber == 0)
            {
                return binNumber += 0;
            }
            while (decNumber > 0)
            {
                reverseNumber += decNumber % 2;
                decNumber /= 2;
            }

            for (int i = reverseNumber.Length - 1; i>=0; i--)
            {
                binNumber += reverseNumber[i];
            }
            return binNumber;
        }
    }
}
