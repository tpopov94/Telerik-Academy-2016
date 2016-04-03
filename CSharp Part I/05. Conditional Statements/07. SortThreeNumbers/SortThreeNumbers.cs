/*
Write a program that enters 3 real numbers and prints them sorted in descending order.

    Use nested if statements.
    Don’t use arrays and the built-in sorting functionality.
*/

namespace _07.SortThreeNumbers
{
    using System;

    public class SortThreeNumbers
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
                }
            }

            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
                }
            }

            else if (thirdNumber >= secondNumber && thirdNumber >= firstNumber)
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
                }
            }
        }
    }
}
