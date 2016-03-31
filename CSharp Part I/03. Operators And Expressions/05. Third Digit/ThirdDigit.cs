namespace _05.Third_Digit
{
    using System;

    public class ThirdDigit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int thirdNumber = number / 100;

            if (thirdNumber == 7)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine("{0} {1}", false, thirdNumber);
            }
        }
    }
}
