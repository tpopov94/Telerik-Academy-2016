namespace _01.Leap_Year
{
    using System;

    public class LeapYear
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", IsLeapYear(input) ? "Leap" : "Common");
        }

        public static bool IsLeapYear(int year)
        {
            bool isLeap = DateTime.IsLeapYear(year);
            
            return isLeap;
        }
    }
}
