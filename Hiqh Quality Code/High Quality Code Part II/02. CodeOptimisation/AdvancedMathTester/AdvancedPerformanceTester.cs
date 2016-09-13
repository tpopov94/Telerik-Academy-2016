namespace AdvancedMathTester
{
    using SimpleMathTester;
    using System;
    using System.Diagnostics;

    public static class AdvancedPerformanceTester
    {
        private const float FLOAT = 1F;
        private const double DOUBLE = 1.0;
        private const decimal DECIMAL = 1.0m;
        private const long OPERATIONS = 100000000;
        private const int OPERAND = 2;

        public static void AdvancedOperationTimeMeasurer(Operation operation, DataType dataType)
        {
            dynamic result = 0;

            switch (dataType)
            {
                case DataType.Float:
                    result = FLOAT;
                    break;
                case DataType.Double:
                    result = DOUBLE;
                    break;
                case DataType.Decimal:
                    result = DECIMAL;
                    break;
                default: throw new ArgumentException("Invalid data type");
            }

            var stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < OPERATIONS; i++)
            {
                switch (operation)
                {
                    case Operation.SquareRoot:
                        result = Math.Sqrt(OPERAND);
                        break;
                    case Operation.Sinus:
                        result = Math.Sin(OPERAND);
                        break;
                    case Operation.NaturalLogarithm:
                        result = Math.Log(OPERAND);
                        break;
                    default: throw new ArgumentException("Invalid operation");
                }
            }
            var elapsedTime = stopwatch.Elapsed;
            Console.WriteLine("Datatype: {0,-8} - Opearation: {1, -17} Time: {2}", dataType, operation, elapsedTime);

        }
    }
}
