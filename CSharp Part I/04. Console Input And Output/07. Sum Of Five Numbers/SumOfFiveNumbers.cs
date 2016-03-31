namespace _07.Sum_Of_Five_Numbers
{
    using System;

    public class SumOfFiveNumbers
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            double fourthNumber = double.Parse(Console.ReadLine());
            double fifthNumber = double.Parse(Console.ReadLine());
            double sum = fifthNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber;

            Console.WriteLine(sum);
        }
    }
}
