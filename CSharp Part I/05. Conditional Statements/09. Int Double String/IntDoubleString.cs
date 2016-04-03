/*
Write a program that, depending on the first line of the input, reads an int, double or string 
variable.
    If the variable is int or double, the program increases it by one.
    If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.
*/
namespace _09.Int_Double_String
{
    using System;

    public class IntDoubleString
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string value = Console.ReadLine();

            switch (type)
            {
                case "integer":
                    Console.WriteLine("{0}", int.Parse(value) + 1);
                    break;
                case "real":
                    Console.WriteLine("{0:F2}", double.Parse(value) + 1);
                    break;
                case "text":
                    Console.WriteLine(value + "*");
                    break;
                default: Console.WriteLine(1); break;
            }
        }
    }
}
