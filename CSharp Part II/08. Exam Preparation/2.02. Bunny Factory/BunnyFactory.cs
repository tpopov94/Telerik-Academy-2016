namespace _02.Bunny_Factory
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    public class BunnyFactory
    {
        static void Main()
        {
            var listOfNumbers = new List<int>();

            // input
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                listOfNumbers.Add(int.Parse(input));
            }


            for (int cycleCounter = 1; ; cycleCounter++)
            {
                int cagesCount = 0;
                for (int i = 0; i < cycleCounter; i++)
                {
                    cagesCount += listOfNumbers[i];
                }

                if (listOfNumbers.Count - cycleCounter < cagesCount)
                {
                    break;
                }

                string currCages = CurrentCages(cycleCounter, cagesCount, listOfNumbers);
                listOfNumbers = StringToList(currCages);
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }

        static string CurrentCages(int cycleCounter, int cagesCount, List<int> listOfNumbers)
        {
            StringBuilder result = new StringBuilder();
            long sum = 0;
            long product = 1;
            int limit = cagesCount + cycleCounter;
            for (int i = cycleCounter; i < cagesCount + cycleCounter; i++)
            {
                sum += listOfNumbers[i];
                product *= listOfNumbers[i];
            }
            result.Append(sum);
            result.Append(product);

            for (int i = limit; i < listOfNumbers.Count; i++)
            {
                result.Append(listOfNumbers[i]);
            }

            return RemoveOnesAndZeroes(result.ToString());
        }

        // Remove ones and zeroes
        static string RemoveOnesAndZeroes(string digits)
        {
            string result = string.Empty;

            foreach (var symbol in digits)
            {
                int number = symbol - '0';
                if (number != 0 && number != 1)
                {
                    result += number;
                }
            }
            return result;
        }

        static List<int> StringToList(string digits)
        {
            var listOfInts = new List<int>();

            foreach (var symbol in digits)
            {
                int curDigits = symbol - '0';
                listOfInts.Add(curDigits);
            }

            return listOfInts;
        }
    }
}
