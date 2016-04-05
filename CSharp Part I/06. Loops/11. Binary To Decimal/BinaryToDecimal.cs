/*
Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
*/

namespace _11.Binary_To_Decimal
{
    using System;

    public class BinaryToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            long result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int num = input[i] - 48;

                if (num == 1)
                {
                    result += (Power(2, input.Length - i - 1));
                }
            }

            Console.WriteLine(result);
        }

        public static long Power(int number, int power)
        {
            long result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
