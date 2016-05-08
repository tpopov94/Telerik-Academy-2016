// Write a program to convert hexadecimal numbers to binary numbers (directly).
// There should not be leading zeros
namespace _05.HexaDecimal_To_Binary
{
    using System;

    public class HexToBin
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(HexToBinary(input));
        }

        public static string HexToBinary(string hexNumber)
        {
            string binary = string.Empty;

            foreach (var symbol in hexNumber)
            {
                switch (symbol)
                {
                    case '0': binary += "0000"; break;
                    case '1': binary += "0001"; break;
                    case '2': binary += "0010"; break;
                    case '3': binary += "0011"; break;
                    case '4': binary += "0100"; break;
                    case '5': binary += "0101"; break;
                    case '6': binary += "0110"; break;
                    case '7': binary += "0111"; break;
                    case '8': binary += "1000"; break;
                    case '9': binary += "1001"; break;
                    case 'A': binary += "1010"; break;
                    case 'B': binary += "1011"; break;
                    case 'C': binary += "1100"; break;
                    case 'D': binary += "1101"; break;
                    case 'E': binary += "1110"; break;
                    case 'F': binary += "1111"; break;
                }
            }

            return TrimLeadingZeroes(binary);
        }

        public static string TrimLeadingZeroes(string input)
        {
            string trimedZeroes = string.Empty;
            bool zero = true;

            foreach (var symbol in input)
            {
                if (zero && symbol == '0')
                {
                    continue;
                }
                else
                {
                    zero = false;
                    trimedZeroes += symbol;
                }
            }

            return trimedZeroes;
        }
    }
}
