namespace _04.Moving_Letters
{
    using System;
    using System.Text;
    using System.Linq;

    public class MovingLetters
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ');
            StringBuilder text = ExtractLetters(words);
            string result = MoveLetters(text);

            Console.WriteLine(result);
            
        }

        // Extract Letters
        static StringBuilder ExtractLetters(string[] words)
        {
            // check max word length
            int maxWordLength = 0;
            var text = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (maxWordLength < words[i].Length)
                {
                    maxWordLength = words[i].Length;
                }
            }

            for (int i = 0; i < maxWordLength; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    string currentWord = words[j];

                    if (currentWord.Length > i)
                    {
                        int lastLetter = currentWord.Length - 1 - i;
                        text.Append(currentWord[lastLetter]);
                    }
                }
            }

            return text;
        }

        // Move letters

        static string MoveLetters(StringBuilder words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                char currentSymbol = words[i];
                int transition = char.ToLower(currentSymbol) - 'a' + 1;

                int nextPosition = (i + transition) % (words.Length);
                words.Remove(i, 1);
                words.Insert(nextPosition, currentSymbol);
            }

            return words.ToString();
        }
    }
}
