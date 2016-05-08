// Write a program that converts a hexadecimal number N to its decimal representation.
namespace _04.HexaDecimal_To_Decimal
{
    using System;

    public class HexToDec
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(HexToDecimal(input));
        }

        public static long HexToDecimal(string input)
        {
            long decNumber = 0;
            int position = input.Length - 1;

            foreach (var symbol in input)
            {
                switch (symbol)
                {
                    case '0': 
                    case '1': 
                    case '2': 
                    case '3': 
                    case '4': 
                    case '5': 
                    case '6': 
                    case '7': 
                    case '8':   
                    case '9': decNumber += (long)Math.Pow(16, position) * (symbol - 48); break;
                    case 'A': decNumber += (long)Math.Pow(16, position) * 10; break;
                    case 'B': decNumber += (long)Math.Pow(16, position) * 11; break;
                    case 'C': decNumber += (long)Math.Pow(16, position) * 12; break;
                    case 'D': decNumber += (long)Math.Pow(16, position) * 13; break;
                    case 'E': decNumber += (long)Math.Pow(16, position) * 14; break;
                    case 'F': decNumber += (long)Math.Pow(16, position) * 15; break;
                }
                position--;
            }
            return decNumber;
        }
    }
}
