namespace SimpleMathTester
{
    using System;

    public class Starter
    {
        public static void Main(string[] args)
        {
            // Add
            PerformanceTester.OperationTimeMeasurer(DataType.Int, Operation.Add);
            PerformanceTester.OperationTimeMeasurer(DataType.Long, Operation.Add);
            PerformanceTester.OperationTimeMeasurer(DataType.Float, Operation.Add);
            PerformanceTester.OperationTimeMeasurer(DataType.Double, Operation.Add);
            PerformanceTester.OperationTimeMeasurer(DataType.Decimal, Operation.Add);

            Console.WriteLine(new string('-', 66));
            // Substract
            PerformanceTester.OperationTimeMeasurer(DataType.Int, Operation.Subtract);
            PerformanceTester.OperationTimeMeasurer(DataType.Long, Operation.Subtract);
            PerformanceTester.OperationTimeMeasurer(DataType.Float, Operation.Subtract);
            PerformanceTester.OperationTimeMeasurer(DataType.Double, Operation.Subtract);
            PerformanceTester.OperationTimeMeasurer(DataType.Decimal, Operation.Subtract);

            Console.WriteLine(new string('-', 66));
            // Divide
            PerformanceTester.OperationTimeMeasurer(DataType.Int, Operation.Divide);
            PerformanceTester.OperationTimeMeasurer(DataType.Long, Operation.Divide);
            PerformanceTester.OperationTimeMeasurer(DataType.Float, Operation.Divide);
            PerformanceTester.OperationTimeMeasurer(DataType.Double, Operation.Divide);
            PerformanceTester.OperationTimeMeasurer(DataType.Decimal, Operation.Divide);

            Console.WriteLine(new string('-', 66));
            // Multiply
            PerformanceTester.OperationTimeMeasurer(DataType.Int, Operation.Multiply);
            PerformanceTester.OperationTimeMeasurer(DataType.Long, Operation.Multiply);
            PerformanceTester.OperationTimeMeasurer(DataType.Float, Operation.Multiply);
            PerformanceTester.OperationTimeMeasurer(DataType.Double, Operation.Multiply);
            PerformanceTester.OperationTimeMeasurer(DataType.Decimal, Operation.Multiply);

            Console.WriteLine(new string('-', 66));
            // Increment
            PerformanceTester.OperationTimeMeasurer(DataType.Int, Operation.Increment);
            PerformanceTester.OperationTimeMeasurer(DataType.Long, Operation.Increment);
            PerformanceTester.OperationTimeMeasurer(DataType.Float, Operation.Increment);
            PerformanceTester.OperationTimeMeasurer(DataType.Double, Operation.Increment);
            PerformanceTester.OperationTimeMeasurer(DataType.Decimal, Operation.Increment);

            Console.WriteLine(new string('-', 66));
        }
    }
}
