//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Linq;
namespace _07.Workdays
{
    class Workdays
    {
        static readonly DateTime[] holidays =
        {
            new DateTime(2016, 1, 1), new DateTime(2016, 3, 3), new DateTime(2016, 3, 4),
            new DateTime(2015, 5, 2), new DateTime(2015, 4, 29), new DateTime(2016, 5, 1),
            new DateTime(2016, 5, 6), new DateTime(2016, 5, 24), new DateTime(2016, 9, 6),
            new DateTime(2016, 9, 5), new DateTime(2016, 9, 22), new DateTime(2016, 12, 24),
            new DateTime(2016, 12, 25)
    };

        static readonly DateTime[] workingWeekends =
        {
            new DateTime(2016, 3, 12), new DateTime(2016, 9, 10), new DateTime(2016, 5, 14),
            new DateTime(2016, 9, 17)
    };

        static void Main()
        {
            DateTime dateNow = DateTime.Now;
            Console.WriteLine("Please enter a date from today till 31.12.2016 in the format DD-MM-YYYY: ");
            Console.Write("Date: ");
            string input = Console.ReadLine();
            char[] separators = { ' ', '.', ',', '-' };
            int[] splittedInput = input.Split(separators).Select(int.Parse).ToArray();
            DateTime dateFuture = new DateTime(splittedInput[2], splittedInput[1], splittedInput[0]);
            Console.WriteLine("Checking work days from {0:dd/MM/yyyy} to {1:dd/MM/yyyy}: {2}", dateNow, dateFuture,
                GetNumberOfWorkDays(dateNow, dateFuture));
        }

        static int GetNumberOfWorkDays(DateTime dateNow, DateTime dateFuture)
        {
            int numberOfWorkDays = 0;

            if (dateNow > dateFuture)
            {
                DateTime swap = dateNow;
                dateNow = dateFuture;
                dateFuture = swap;
            }

            while (dateNow <= dateFuture)
            {
                if (!holidays.Contains(dateNow)
                && !workingWeekends.Contains(dateNow)
                && dateNow.DayOfWeek != DayOfWeek.Saturday
                && dateNow.DayOfWeek != DayOfWeek.Sunday)
                {
                    numberOfWorkDays++;
                }
                dateNow = dateNow.AddDays(1);
            }
            return numberOfWorkDays;
        }
    }
}