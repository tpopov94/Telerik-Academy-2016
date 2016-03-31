namespace _01.Exchange_Values
{
    using System;
    
    public class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
           

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("{0} {1}", secondNumber, firstNumber);
               
            }
            else
            {
                Console.WriteLine("{0} {1}", firstNumber, secondNumber);
            }
        }
    }
}
