namespace _01.StrangeLand_Numbers
{
    using System;
    using System.Numerics;

    class StrangeLandNumbers
    {
        static void Main()
        {
            string strangeNumber = Console.ReadLine()
                .Replace("f", "0")
                .Replace("bIN", "1")
                .Replace("oBJEC", "2")
                .Replace("mNTRAVL", "3")
                .Replace("lPVKNQ", "4")
                .Replace("pNWE", "5")
                .Replace("hT", "6");

            Console.WriteLine(DecimalToSevenSys(strangeNumber));
        }

        static BigInteger DecimalToSevenSys(string input)
        {
            BigInteger result = 0;
            int position = input.Length - 1;

            foreach (var number in input)
            {
                int curNumber = number - '0';
                result += (BigInteger)Math.Pow(7, position) * curNumber;
                position--;
            }

            return result;
        }

    }
}
