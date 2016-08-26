namespace PrintStatistics
{
    using System.Linq;

    public static class ArrayExtensions
    {
        public static double FindMin(double[] numbers)
        {
            double minNumber = numbers.Min();

            return minNumber;
        }

        public static double FindMax(double[] numbers)
        {
            double maxNumber = numbers.Max();
                    
            return maxNumber;
        }

        public static double FindAverage(double[] numbers)
        {
            return numbers.Average();
        }
    }
}
