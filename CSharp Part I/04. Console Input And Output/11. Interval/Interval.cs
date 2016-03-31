namespace _11.Interval
{
    using System;

    public class Interval
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = n; i <= m; i++)
            {
                if ( i % 5 == 0)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
