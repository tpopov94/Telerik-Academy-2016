//Write a program to convert binary numbers to hexadecimal numbers (directly).
// There should not be leading zeroes in output
namespace _06.Binary_To_HexaDecimal
{
    using System;

    public class BinToHex
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(BinaryToHex(input));
        }

        public static string BinaryToHex(string number)
        {
            number = AddLeadingZeroes(number);
            string hexNumber = string.Empty;
            string binNumber = string.Empty;
            for (int i = 0; i < number.Length; i += 4)
            {
                binNumber = number.Substring(i, 4);

                switch (binNumber)
                {
                    case "0000": hexNumber += "0"; break;
                    case "0001": hexNumber += "1"; break;
                    case "0010": hexNumber += "2"; break;
                    case "0011": hexNumber += "3"; break;
                    case "0100": hexNumber += "4"; break;
                    case "0101": hexNumber += "5"; break;
                    case "0110": hexNumber += "6"; break;
                    case "0111": hexNumber += "7"; break;
                    case "1000": hexNumber += "8"; break;
                    case "1001": hexNumber += "9"; break;
                    case "1010": hexNumber += "A"; break;
                    case "1011": hexNumber += "B"; break;
                    case "1100": hexNumber += "C"; break;
                    case "1101": hexNumber += "D"; break;
                    case "1110": hexNumber += "E"; break;
                    case "1111": hexNumber += "F"; break;
                }
            }

            return TrimLeadingZeroes(hexNumber);
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

        public static string AddLeadingZeroes(string input) // We receive the number without the leading zeroes, so sometimes we must add them to convert the number
        {
            long length = input.Length;
            long zeroesToAdd = 4 - (length % 4);

            return (new string('0', (int)zeroesToAdd) + input);
        }
    }
}
