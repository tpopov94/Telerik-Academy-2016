// Write a program that converts a binary number N to its decimal representation.
namespace _02.Binary_To_Decimal
{
    using System;

    public class BinToDec
    {
        static void Main()
        {
            string binNumber = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(binNumber));
        }

        public static long BinaryToDecimal(string input)
        {
            long decNumber = 0;
            int position = input.Length - 1;

            for (int i = 0; i < input.Length; i++)
            {
                int number = input[i] - 48;
                decNumber += (long)Math.Pow(2, position) * number;
                position--;
            }

            return decNumber;
        }
    }
}
