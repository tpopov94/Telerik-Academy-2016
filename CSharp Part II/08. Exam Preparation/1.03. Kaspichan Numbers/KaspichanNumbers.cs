namespace _03.Kaspichan_Numbers
{
    using System;
    using System.Collections.Generic;
  
    public class KaspichanNumbers
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            string result = string.Empty;
            var kaspichanDigits = new List<string>();

            for (char i = 'A'; i <= 'Z'; i++)
            {
                kaspichanDigits.Add(i.ToString());
            }

            for (char i = 'a'; i <= 'i'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    kaspichanDigits.Add(i.ToString() + j.ToString());
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
                    result = kaspichanDigits[(int)(number % 256)] + result;
                    number /= 256;
                }

                Console.WriteLine(result);
            }
           
        }

    }
}
