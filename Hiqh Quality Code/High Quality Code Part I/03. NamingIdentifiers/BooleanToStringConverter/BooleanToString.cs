namespace BooleanToStringConverter
{
    using System;

    public class BooleanToString
    {
        public static void PrintSolution()
        {
            BooleanToString converter = new BooleanToString();

            converter.BooleanToStringConverter(true);
        }

        public void BooleanToStringConverter(bool isTrue)
        {
            string booleanAsString = isTrue.ToString();

            Console.WriteLine(booleanAsString);
        }
    }
}
