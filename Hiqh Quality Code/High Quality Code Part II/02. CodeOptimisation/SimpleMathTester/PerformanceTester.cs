namespace SimpleMathTester
{
    using System;
    using System.Diagnostics;

    public static class PerformanceTester
    {
        private const int INTEGER = 1;
        private const long LONG_INT = 1L;
        private const float FLOAT = 1F;
        private const double DOUBLE = 1.0;
        private const decimal DECIMAL = 1M;
        private const long OPERATIONS = 50000000;
        private const int OPERAND = 1;

        public static void OperationTimeMeasurer(DataType dataType, Operation operation)
        {
            dynamic result = 0;

            switch (dataType)
            {
                case DataType.Int:
                    result = INTEGER;
                    break;
                case DataType.Long:
                    result = LONG_INT;
                    break;
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
                    case Operation.Add:
                        result += OPERAND;
                        break;
                    case Operation.Subtract:
                        result -= OPERAND;
                        break;
                    case Operation.Increment:
                        result++;
                        break;
                    case Operation.Multiply:
                        result *= OPERAND;
                        break;
                    case Operation.Divide:
                        result /= OPERAND;
                        break;
                    default: throw new ArgumentException("Invalid operation");
                }
            }
            var elapsedTime = stopwatch.Elapsed;
            Console.WriteLine("Datatype: {0,-8} - Opearation: {1, -10} Time: {2}", dataType, operation, elapsedTime);
        }
    }
}
