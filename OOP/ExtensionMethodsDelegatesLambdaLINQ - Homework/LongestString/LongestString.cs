namespace LongestString
{
    using System;
    using System.Linq;


    public class LongestString // Task 17 Write a program to return the string with maximum length from an array of strings.
    {
        static void Main()
        {
            string[] someStrings =
            {
                "Balkan Superman",
                "I cannot think of anything after all the students",
                "I think that my name is student",
                "Mind Blown",
                "Yu-Gi-Oh",
                "I am kind a retarded"
            };

            var sorted =
                from strings in someStrings
                orderby strings.Length descending
                select strings;

            string longest = sorted.FirstOrDefault();

            Console.WriteLine(longest);
        }
    }
}
