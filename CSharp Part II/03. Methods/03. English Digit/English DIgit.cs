//Write a method that returns the last digit of given integer as an English word.
namespace _03.English_Digit
{
    using System;

    public class EnglishDigit
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(LastDigitAsWord(input));
        }

        static string LastDigitAsWord(int number)
        {
            int lastNumber = number % 10;
            string digitAsString = null;

            switch (lastNumber)
            {
                case 1: digitAsString = "one"; break;
                case 2: digitAsString = "two"; break;
                case 3: digitAsString = "three"; break;
                case 4: digitAsString = "four"; break;
                case 5: digitAsString = "five"; break;
                case 6: digitAsString = "six"; break;
                case 7: digitAsString = "seven"; break;
                case 8: digitAsString = "eight"; break;
                case 9: digitAsString = "nine"; break;
                case 0: digitAsString = "zero"; break;
                default: throw new ArgumentException("You must enter a valid integer!");
            }

            return digitAsString;
        }
    }
}
