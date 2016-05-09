// Write a program to convert the number N from any numeral system of given base s to any other numeral system of base d.
namespace _07.One_System_To_Any_Other
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int fromBase = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            long decimalNumber = ConvertToDecimal(number, fromBase);
            Console.WriteLine(ConvertFromDecimal(decimalNumber, toBase));
        }

        static long ConvertToDecimal(string number, int fromBase) // Convert the N-base number to decimal
        {
            long result = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(number[i]))
                {
                    result += int.Parse(number[i].ToString()) * (long)Math.Pow(fromBase, number.Length - i - 1);
                }
                else
                {
                    result += (number[i] - 'A' + 10) * (long)Math.Pow(fromBase, number.Length - i - 1);
                }
            }
            return result;
        }

        static string ConvertFromDecimal(long number, int toBase) // Convert the decimal number to N-base number
        {
            string result = "";
            if (number == 0)
            {
                result = "0";
            }
            else
            {
                while (number > 0)
                {
                    if (number % toBase < 10)
                    {
                        result = number % toBase + result;
                    }
                    else
                    {
                        result = (char)(number % toBase + 'A' - 10) + result;
                    }
                    number /= toBase;
                }
            }
            return result;
        }
    }
}
