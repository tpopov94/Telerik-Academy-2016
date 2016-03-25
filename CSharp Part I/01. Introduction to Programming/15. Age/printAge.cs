namespace _15.Age
{
    using System;

    public class PrintAge
    {
        static void Main()
        {
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;

            int age;

            age = today.Year - birthday.Year; if (today.Month < birthday.Month)

            {
                age = today.Year - birthday.Year - 1;
            }

            else if (today.Month > birthday.Month)

            {
                age = today.Year - birthday.Year;
            }

            else

            {
                if (today.Day < birthday.Day)

                {
                    age = today.Year - birthday.Year - 1;
                }

                else

                {
                    age = today.Year - birthday.Year;

                }
            }

            Console.WriteLine(age);
            Console.WriteLine(age + 10);

        }
    }
}
