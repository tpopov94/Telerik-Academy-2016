namespace SumOfThreeNumbers
{
    using System;

    public class SumOfThreeNumbers
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int sum;

            sum = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine(sum);
        }
    }
}
