namespace _03.Divide_By_Five_And_Seven
{
    using System;

    public class DivideByNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 35 == 0)
            {
                Console.WriteLine("true {0}", number);
            }
            else
            {
                Console.WriteLine("false {0}", number);
            }
        }
    }
}
