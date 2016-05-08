// Extend the previous program to support also subtraction and multiplication of polynomials.
namespace _12.Subtracting_Polynomials
{
    using System;
    using System.Linq;
    using _11.Adding_Polynomials; // We use the previous project to use the AddPolynomials method

    public class SubtractingPolynomials
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] firstArrayOfNumbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int[] secondArrayOfNumbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            var resultArray = AddingPolynomials.AddPolynomials(firstArrayOfNumbers, secondArrayOfNumbers, length);

            // Add
            Console.WriteLine(String.Join(" ", resultArray));
            resultArray = MultiplyPolynomials(firstArrayOfNumbers, secondArrayOfNumbers, length);
            // multiply
            Console.WriteLine(String.Join(" ", resultArray));
            resultArray = SubtractPolynomials(firstArrayOfNumbers, secondArrayOfNumbers, length);
            // Subtract
            Console.WriteLine(String.Join(" ", resultArray));
        }

        public static int[] SubtractPolynomials(int[] firstArray, int[] secondArray, int length)
        {
            int[] resultArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                resultArray[i] = firstArray[i] - secondArray[i];
            }

            return resultArray;
        }

        public static int[] MultiplyPolynomials(int[] firstArray, int[] secondArray, int length)
        {
            int[] resultArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                resultArray[i] = firstArray[i] * secondArray[i];
            }

            return resultArray;
        }
    }
}
