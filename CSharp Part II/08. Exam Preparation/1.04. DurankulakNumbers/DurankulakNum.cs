namespace _04.DurankulakNumbers
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;

    public class DurankulakNum
    {
        static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            var durankulakNumber = new List<string>();
            string result = string.Empty;

            for (char i = 'A'; i <= 'Z' ; i++)
            {
                durankulakNumber.Add(i.ToString());
            }

            for (char i = 'a'; i <= 'f'; i++)
            {
                for (char l = 'A'; l <= 'Z'; l++)
                {
                    durankulakNumber.Add(i.ToString() + l);
                }
            }

            if (number == 0)
            {
                Console.WriteLine("A");
            }
            else
            {
                while (number != 0)
                {
                    result = durankulakNumber[(int)(number % 168)] + result;
                    number /= 256;
                }
                Console.WriteLine(result);
            }
        }
    }
}
