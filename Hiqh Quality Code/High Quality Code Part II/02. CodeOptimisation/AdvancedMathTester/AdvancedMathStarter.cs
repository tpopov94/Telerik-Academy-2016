namespace AdvancedMathTester
{
    using System;

    using SimpleMathTester;

    public class AdvancedMathStarter
    {
        public static void Main()
        {
            // Square Root
            AdvancedPerformanceTester.AdvancedOperationTimeMeasurer(Operation.SquareRoot, DataType.Float);
            AdvancedPerformanceTester.AdvancedOperationTimeMeasurer(Operation.SquareRoot, DataType.Double);
            AdvancedPerformanceTester.AdvancedOperationTimeMeasurer(Operation.SquareRoot, DataType.Decimal);

            Console.WriteLine(new string('-', 73));

            // Sinus
            AdvancedPerformanceTester.AdvancedOperationTimeMeasurer(Operation.Sinus, DataType.Float);
            AdvancedPerformanceTester.AdvancedOperationTimeMeasurer(Operation.Sinus, DataType.Double);
            AdvancedPerformanceTester.AdvancedOperationTimeMeasurer(Operation.Sinus, DataType.Decimal);

            Console.WriteLine(new string('-', 73));

            // Natural Logarithm
            AdvancedPerformanceTester.AdvancedOperationTimeMeasurer(Operation.NaturalLogarithm, DataType.Float);
            AdvancedPerformanceTester.AdvancedOperationTimeMeasurer(Operation.NaturalLogarithm, DataType.Double);
            AdvancedPerformanceTester.AdvancedOperationTimeMeasurer(Operation.NaturalLogarithm, DataType.Decimal);

            Console.WriteLine(new string('-', 73));
        }
    }
}

