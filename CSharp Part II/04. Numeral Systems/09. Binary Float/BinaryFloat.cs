//Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
namespace _09.Binary_Float
{
    using System;

    public class BinaryFloat
    {
        static void Main()
        {
            float input = float.Parse(Console.ReadLine());
            string inputToBinary = FloatToBinary(input);
            //The first bit is the sign (0 for positive, 1 for negative)
            //The next 8 bits are the exponent, the rest are the mantissa
            Console.WriteLine("{0}{1}{2}", inputToBinary[0], inputToBinary.Substring(1, 8), inputToBinary.Substring(9, 22));
        }

        static string FloatToBinary(float number)
        {
            byte[] bytesInput = BitConverter.GetBytes(number); //number as an array of 4 bytes
            string inputToBinary = "";
            for (int i = 0; i < bytesInput.Length; i++) //convert each byte to its binary representation and pad
            {
                inputToBinary = Convert.ToString(bytesInput[i], 2).PadLeft(8, '0') + inputToBinary;
            }
            return inputToBinary;
        }
    }
}
