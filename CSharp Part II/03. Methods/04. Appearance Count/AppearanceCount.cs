//Write a method that counts how many times given number appears in a given array.
namespace _04.Appearance_Count
{
    using System;
    using System.Linq;

    public class AppearanceCount
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            decimal[] arrayOfNumber = Console.ReadLine().Split(' ').Select(s => decimal.Parse(s)).ToArray();
            decimal searchedNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine(AppearanceCountInArray(arrayOfNumber, searchedNumber));      
        }

        static int AppearanceCountInArray(decimal[] arrayOfNumbers, decimal searchedNumber)
        {
            int counter = 0;
            foreach (var number in arrayOfNumbers)
            {
                if (number == searchedNumber)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
