//Implement an extension method Substring(int index, int length) for the class StringBuilder 
//that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace StringBuilderSubstring
{
    using System;
    using System.Text;

    public static class StringBuilderExtension // Task 1
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int length) // Substring from start point + number of symbols
        {
            var result = new StringBuilder();
            string subString = text.ToString();

            //Checking for OutOfRabnge errors
            if (index < 0 || index > subString.Length)
            {
                throw new ArgumentOutOfRangeException("This index is outside of the string length");
            }
            else if (index + length > subString.Length)
            {
                 throw new ArgumentOutOfRangeException("This index is outside of the string length");
            }

            // The real deal

            for (int i = index; i < index + length; i++)
            {
                result.Append(subString[i]);
            }
            return result;
        }

        public static StringBuilder Substring(this StringBuilder text, int index)  // Substring from starting index to the end of the string
        {
            var result = new StringBuilder();
            string subString = text.ToString();

            //Checking for OutOfRabnge errors
            if (index < 0 || index > subString.Length)
            {
                throw new ArgumentOutOfRangeException("This index is outside of the string length");
            }

            // The real deal

            for (int i = index; i < subString.Length; i++)
            {
                result.Append(subString[i]);
            }
            return result;
        }
    }
}
