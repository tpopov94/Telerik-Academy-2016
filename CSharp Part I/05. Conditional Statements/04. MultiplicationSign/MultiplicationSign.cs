// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.

namespace _04.MultiplicationSign
{
    using System;

    public class MultiplicationSign
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine(0);
            }

            if ((firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) ||
           (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0) ||
           (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) ||
           (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0))
            {
                Console.WriteLine("+");
            }
            if ((firstNumber < 0 && secondNumber < 0 && thirdNumber < 0) ||
            (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0) ||
            (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0) ||
            (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0))
            {
                Console.WriteLine("-");
            }
        }
    }
}
