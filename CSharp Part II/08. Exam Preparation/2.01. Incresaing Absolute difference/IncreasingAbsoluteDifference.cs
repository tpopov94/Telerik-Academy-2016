namespace _01.Incresaing_Absolute_difference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncreasingAbsoluteDifference
    {
        static void Main()
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            var listOfNumbers = new List<int>();
            var seqList = new List<int>();

            for (int j = 0; j < numberOfRows; j++)
            {
                listOfNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();

                // Adding sequence list
                for (int i = 1; i < listOfNumbers.Count; i++)
                {
                    int max = MaxNumber(listOfNumbers[i], listOfNumbers[i - 1]);
                    int min = MinNumber(listOfNumbers[i], listOfNumbers[i - 1]);
                    seqList.Add(max - min);
                }

                // sequence checker
                bool flag = true;

                for (int i = 1; i < seqList.Count; i++)
                {
                    if (!flag)
                    {
                        break;
                    }
                    if (seqList[i] < seqList[i-1])
                    {
                        flag = false;
                    }
                    if (flag)
                    {
                        if ((seqList[i] - seqList[i - 1]) != 0 && (seqList[i] - seqList[i - 1]) != 1)
                        {
                            flag = false;
                        }
                    }
                }

                // result

                if (flag)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }

                seqList.Clear();
                listOfNumbers.Clear();
            }
        }

        public static int MinNumber (int a, int b)
        {
            int min = a;

            if (min > b)
            {
                min = b;
            }

            return min;
        }

        public static int MaxNumber(int a, int b)
        {
            int max = a;

            if (max < b)
            {
                max = b;
            }

            return max;
        }
    }
}
