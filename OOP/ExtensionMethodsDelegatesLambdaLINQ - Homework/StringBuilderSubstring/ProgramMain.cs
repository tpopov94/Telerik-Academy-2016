namespace StringBuilderSubstring
{
    using System;
    using System.Text;


    public class ProgramMain
    {
        static void Main()
        {
            //Console.WriteLine("Enter something to test the StringBuilder.Substring extension");
            //string input = Console.ReadLine();
            var test = new StringBuilder("Some sentence");

            Console.WriteLine(test.Substring(3, 4)); // Result
            Console.WriteLine(test.Substring(2));
        }
    }
}
