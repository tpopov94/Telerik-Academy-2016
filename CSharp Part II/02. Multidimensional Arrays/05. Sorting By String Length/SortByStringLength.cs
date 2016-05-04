namespace _05.Sorting_By_String_Length
{
    using System;
    using System.Linq;

    public class SortByStringLength
    {
        static void Main()
        {
            string[] stringArray =
            {
                "tomato",
                "potato",
                "apple",
                "banana",
                "bananas"
            };

            stringArray = stringArray.OrderBy(s => s.Length).ToArray();
            Console.WriteLine(string.Join(", ", stringArray));
        }
    }
}
