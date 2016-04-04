namespace _01.Numbers_From_One_To_N
{
    using System;

    public class NumbersFromOneToN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = "1";

            for (int i = 2; i <= n; i++)
            {
                result += " " + i;
            }

            Console.WriteLine(result);
        }
    }
}
