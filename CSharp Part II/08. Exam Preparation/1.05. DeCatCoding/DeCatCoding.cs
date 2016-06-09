namespace _05.DeCatCoding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DeCatCoding
    {
        public static void Main()
        {
            var humanAlphabet = HumanAlphabet();
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            ulong decResult = 0;
            var resultArray = new List<string>();

            foreach (var word in input)
            {
                decResult = 0;
                int power = word.Length - 1;
                for (int i = 0; i < word.Length; i++)
                {
                    ulong digit = (ulong)word[i] - 'a';
                    decResult += (ulong)Math.Pow(21, power) * digit;
                    power--;
                }

                resultArray.Add(CatMessage(decResult, humanAlphabet));
            }

            Console.WriteLine(string.Join(" ", resultArray));

        }

        public static string CatMessage(ulong decResult, List<string> humanAlphabet)
        {
            string result = string.Empty;

            while (decResult != 0)
            {
                result = humanAlphabet[(int)(decResult % 26)] + result;
                decResult /= 26;
            }
            return result;
        }

        public static List<string> HumanAlphabet()
        {
            var humanAlphabet = new List<string>();

            for (char i = 'a'; i <= 'z'; i++)
            {
                humanAlphabet.Add(i.ToString());
            }
            return humanAlphabet;
        }
    }
}
