namespace _08.Numbers_From_One_To_N
{
    using System;

    public class NumbersFromOneToN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
