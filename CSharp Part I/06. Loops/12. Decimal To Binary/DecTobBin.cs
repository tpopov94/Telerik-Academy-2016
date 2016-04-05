/*Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.
*/

namespace _12.Decimal_To_Binary
{
    using System;

    public class DecTobBin
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            string binary = string.Empty;

            while ( number > 0)
            {
                binary += number % 2;
                number = number / 2;
            }

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
        }
    }
}
