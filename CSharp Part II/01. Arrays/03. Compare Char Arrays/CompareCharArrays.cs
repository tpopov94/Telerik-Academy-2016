/*
Write a program that compares two char arrays lexicographically (letter by letter).
    Print < if the first array is lexicographically smaller
    Print > if the second array is lexicographically smaller
    Print = if the arrays are equal
*/
namespace _03.Compare_Char_Arrays
{
    using System;

    public class CompareCharArrays
    {
        static void Main()
        {
            string firstCharArray = Console.ReadLine();
            string secondCharArray = Console.ReadLine();
            int length = Math.Min(firstCharArray.Length, secondCharArray.Length);

            if (firstCharArray.Length == secondCharArray.Length)
            {
                for (int index = 0; index < length; index++)
                {
                    if (firstCharArray[index] > secondCharArray[index])
                    {
                        Console.WriteLine(">");
                        break;
                    }
                    else if (firstCharArray[index] < secondCharArray[index])
                    {
                        Console.WriteLine("<");
                        break;
                    }
                }
                Console.WriteLine("=");
            }
            if (firstCharArray.Length > secondCharArray.Length)
            {
                Console.WriteLine(">");
            }
            if (firstCharArray.Length < secondCharArray.Length)
            {
                Console.WriteLine("<");
            }
        }
    }
}
