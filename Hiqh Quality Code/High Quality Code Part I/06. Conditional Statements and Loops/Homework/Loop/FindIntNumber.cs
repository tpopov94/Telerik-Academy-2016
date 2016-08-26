namespace Loop
{
    using System;

    public class FindIntNumber
    {
        public void PrintValue(int expectedValue)
        {
            int[] values = new int[100];

            for (int i = 0; i < values.Length; i++)
            {
                if (i % 10 == 0 && values[i] == expectedValue)
                {
                    Console.WriteLine("Value found");
                    break;
                }

                Console.WriteLine(values[i]);
            }
        }
    }
}