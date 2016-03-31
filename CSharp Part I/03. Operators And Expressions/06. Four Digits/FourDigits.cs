namespace _06.Four_Digits
{
    using System;

    public class FourDigits
    {
        static void Main()
        {
            string number = Console.ReadLine();
            var input = number.ToCharArray();

            int firstNumber = input[0] - 48,
                secondNumber = input[1] - 48,
                thirdNumber = input[2] - 48,
                fourthNumber = input[3] - 48,
                sum;

            sum = firstNumber + secondNumber + thirdNumber + fourthNumber;

            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", fourthNumber, thirdNumber, secondNumber, firstNumber);
            Console.WriteLine("{0}{1}{2}{3}", fourthNumber, firstNumber, secondNumber, thirdNumber);
            Console.WriteLine("{0}{1}{2}{3}", firstNumber, thirdNumber, secondNumber, fourthNumber);
        }
    }
}