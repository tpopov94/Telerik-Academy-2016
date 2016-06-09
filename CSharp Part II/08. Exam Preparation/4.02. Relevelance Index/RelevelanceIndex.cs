namespace _02.Relevelance_Index
{
    using System;
    using System.Collections.Generic;

    public class RelevelanceIndex
    {
        static string[] symbols = new string[] { " ", ",", ".", "(", ")", ";", "-", "!", "?" };

        static void Main()
        {
            string searchWord = Console.ReadLine();

            int numberOfParagraphs = int.Parse(Console.ReadLine());

            List<string> paragraphs = new List<string>();
            List<int> index = new List<int>();

            for (int i = 0; i < numberOfParagraphs; i++)
            {
                var currentline = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries);

                int revelanceIndex = 0;
                for (int j = 0; j < currentline.Length; j++)
                {
                    string word = currentline[j];
                    if (word.ToLower() == searchWord.ToLower())
                    {
                        revelanceIndex++;
                        currentline[j] = word.ToUpper();
                    }
                }
                paragraphs.Add(string.Join(" ", currentline));
                index.Add(revelanceIndex);
            }

            List<string> sortedParagraphs = new List<string>();

            while (sortedParagraphs.Count < paragraphs.Count)
            {
                int maxIndex = 0;
                int maxParagraphIndex = 0;

                for (int i = 0; i < index.Count; i++)
                {
                    if (maxIndex < index[i])
                    {
                        maxIndex = index[i];
                        maxParagraphIndex = i;
                    }
                }

                sortedParagraphs.Add(paragraphs[maxParagraphIndex]);
                index[maxParagraphIndex] = -1;
            }

            Console.WriteLine(string.Join(Environment.NewLine, sortedParagraphs));
        }
    }
}
