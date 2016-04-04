namespace _03.Min_Max_Sum_Average_of_N_Numbers
{
    using System;

    public class MMSAOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            double min = Double.MaxValue;
            double sum = 0;
            double currentNumber;

            for (int i = 0; i < n; i++)
            {
                currentNumber = double.Parse(Console.ReadLine());
                sum += currentNumber;

                if (currentNumber < min)
                {
                    min = currentNumber;
                }

                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }

            Console.WriteLine("min={0}", min);
            Console.WriteLine("max={0}", max);
            Console.WriteLine("sum={0}", sum);
            Console.WriteLine("avg={0:F2}", sum / n);
        }
    }
}
