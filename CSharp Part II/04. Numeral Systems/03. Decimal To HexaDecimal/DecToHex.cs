//Write a program that converts a decimal number N to its hexadecimal representation.
namespace _03.Decimal_To_HexaDecimal
{
    using System;

    public class DecToHex
    {
        static void Main()
        {
            long decNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHex(decNumber));
        }

        static string DecimalToHex(long decNumber)
        {
            string hexNumber = string.Empty;

            if (decNumber == 0)
            {
                return hexNumber += 0;
            }
            while (decNumber > 0)
            {
                switch (decNumber % 16)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9: hexNumber = decNumber % 16 + hexNumber; break;
                    case 10: hexNumber = "A" + hexNumber; break;
                    case 11: hexNumber = "B" + hexNumber; break;
                    case 12: hexNumber = "C" + hexNumber; break;
                    case 13: hexNumber = "D" + hexNumber; break;
                    case 14: hexNumber = "E" + hexNumber; break;
                    case 15: hexNumber = "F" + hexNumber; break;
                }
                decNumber /= 16;
            }

            return hexNumber;
        }
    }
}
