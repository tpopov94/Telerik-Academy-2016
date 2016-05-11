// Write a program that prints to the console which day of the week is today. Use System.DateTime.
namespace _03.Day_Of_Week
{
    using System;

    public class Program
    {
        static void Main()
        {
            DayOfWeek();
        }

        public static void DayOfWeek()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today.DayOfWeek); // enum :D
        }
    }
}
