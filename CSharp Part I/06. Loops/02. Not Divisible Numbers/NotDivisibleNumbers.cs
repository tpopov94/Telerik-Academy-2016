namespace _02.Not_Divisible_Numbers
{
    using System;

    public class NotDivisibleNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = "1";

            for (int i = 2; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    result += " " + i;
                }
            }

            Console.WriteLine(result);
        }
    }
}
