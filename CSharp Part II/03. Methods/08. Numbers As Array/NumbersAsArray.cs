/*Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
Write a program that reads two arrays representing positive integers and outputs their sum.*/
namespace _08.Numbers_As_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumbersAsArray
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int[] resultArray = new int[ArrayLength(input[0], input[1])];
            int length = ArrayLength(input[0], input[1]);
            //int[] firstArrayOfNumbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            //int[] secondArrayOfNumbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            var firstArrayOfNumbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            var secondArrayOfNumbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            Console.WriteLine(string.Join(" ", AddLists(firstArrayOfNumbers, secondArrayOfNumbers, length)));
        }

        public static int[] AddLists(List<int> firstArray, List<int> secondArray, int length)
        {
            //List<int> resultArray = new List<int>();
            var resultArray = new int[length];
            EqualizeLists(firstArray, secondArray);

            for (int i = 0; i < resultArray.Length; i++)
            {
                int sum = firstArray[i] + secondArray[i];
                if (sum >= 10)
                {
                    resultArray[i] = sum - 10;
                    if (i < length - 1)
                    {
                        firstArray[i + 1] += 1;
                    }
                }
                else
                {
                    resultArray[i] = sum;
                }
            }

            return resultArray;
        }

        static int ArrayLength(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        public static void EqualizeLists(List<int> firstArray, List<int> secondArray)
        {
            int firstListLength = firstArray.Count;
            int secondListLength = secondArray.Count;

            if (firstListLength > secondListLength)
            {
                int numbersToAdd = firstListLength - secondListLength;
                for (int i = 0; i < numbersToAdd; i++)
                {
                    secondArray.Add(0);
                }
            }
            else
            {
                int numbersToAdd = secondListLength - firstListLength;
                for (int i = 0; i < numbersToAdd; i++)
                {
                    firstArray.Add(0);
                }
            }
        }
    }
}
