namespace _02.Tres4_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    class Tres4Numbers
    {
        static void Main(string[] args)
        {
            //string strangeNumber = Console.ReadLine()
            //    .Replace("LON+", "0")
            //    .Replace("VK-", "1")
            //    .Replace("*ACAD", "2")
            //    .Replace("^MIM", "3")
            //    .Replace("ERIK|", "4")
            //    .Replace("SEY&", "5")
            //    .Replace("EMY>>", "6")
            //    .Replace("/TEL", "7")
            //    .Replace("<<DON", "8");

            BigInteger number = BigInteger.Parse(Console.ReadLine());
            string[] tresNum = new string[] { "LON+", "VK-", "*ACAD", "^MIM",
                                        "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON"};
            string result = string.Empty;

            if (number == 0)
            {
                Console.WriteLine("LON+");
            }
            else
            {
                while (number > 0)
                {
                    result = tresNum[(int)(number % 9)] + result;

                    number /= 9;
                }
            }

            Console.WriteLine(result);
        }
    }
}
