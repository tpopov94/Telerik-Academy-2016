namespace _01.Odd_Or_Even_Number
{
    using System;

    public class OddOrEven
    {
        static void Main()
        {
            short number = short.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("even {0}", number);
            }
            else
            {
                Console.WriteLine("odd {0}", number);
            }
        }
    }
}
