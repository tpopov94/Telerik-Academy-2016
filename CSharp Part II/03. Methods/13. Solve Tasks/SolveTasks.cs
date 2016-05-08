/*Write a program that can solve these tasks:
    Reverses the digits of a number
    Calculates the average of a sequence of integers
    Solves a linear equation a * x + b = 0

Create appropriate methods.
    Provide a simple text-based menu for the user to choose which task to solve.
    Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0
*/

namespace _13.Solve_Tasks
{
    using System;
    using System.Linq;
    public class SolveTasks
    {
        static void Main()
        {
            Menu();
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You choose reverse number!");
                    Console.Write("Enter a number: ");
                    string input = Console.ReadLine();
                    ValidateNonNegativeDecimalNumbers(decimal.Parse(input));
                    Console.WriteLine("Reversed number: {0}", ReverseDigitsOfNumber(input));
                    break;
                case 2:
                    Console.WriteLine("You choose calculate the average of sequence of numbers!");
                    Console.Write("Enter numbers separated by space: ");
                    input = Console.ReadLine();
                    ValidateInput(input);
                    Console.WriteLine("Average: {0:F2}", AverageSumOfIntegers(input));
                    break;
                case 3:
                    Console.WriteLine("You choose linear equation! ax + b = 0");
                    Console.Write("Enter a: ");
                    decimal a = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter a: ");
                    decimal b = decimal.Parse(Console.ReadLine());
                    ValidateLinearEquation(a);
                    Console.WriteLine("Answer: {0:F2}", LinearEquation(a, b));
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong option !!! Try again");
                    Menu();  break;
            }
        }

        public static decimal LinearEquation(decimal a, decimal b = 0)
        {
            return -b / a;
        }

        public static decimal AverageSumOfIntegers(string input)
        {
            decimal[] arrayOfNumbers = input.Split(' ').Select(n => decimal.Parse(n)).ToArray();
            decimal sum = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                sum += arrayOfNumbers[i];
            }

            return sum / arrayOfNumbers.Length;
        }

        public static decimal ReverseDigitsOfNumber(string input)
        {
            string result = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }

            return decimal.Parse(result);
        }

        public static void ValidateInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("Input sequence cannot be null or empty!");
            }
        }

        public static void ValidateNonNegativeDecimalNumbers(decimal number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number must be a positive decimal number");
            }
        }

        public static void ValidateLinearEquation(decimal a)
        {
            if (a == 0)
            {
                throw new ArithmeticException("A must not be a zero!");
            }
        }

        // Menu
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(new string('-', 20));
            Console.Write("Welcome to our program !!");
            Console.WriteLine(new string('-', 20));
            Console.Write(new string('-', 17));
            Console.Write("Choose one of the options below:");
            Console.WriteLine(new string('-', 16));
            Console.WriteLine("1. Reverse the digits of a number");
            Console.WriteLine("2. Calculates the average of a sequence of integers");
            Console.WriteLine("3.  Solves a linear equation a * x + b = 0");
            Console.Write(new string('-', 35));
            Console.WriteLine(new string('-', 30));
            Console.Write(new string('*', 10));
            Console.Write(" Enter your choice: ");
        }
    }
}
