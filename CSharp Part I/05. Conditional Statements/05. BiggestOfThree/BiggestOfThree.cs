// Write a program that finds the biggest of three numbers that are read from the console.

namespace _05.BiggestOfThree
{
    using System;
    public class BiggestOfThree
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else if (thirdNumber >= firstNumber && thirdNumber > firstNumber)
            {
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
