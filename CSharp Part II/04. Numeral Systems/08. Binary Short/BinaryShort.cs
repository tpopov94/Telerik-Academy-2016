// Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type short).
namespace _08.Binary_Short
{
    using System;

    public class BinaryShort
    {
        static void Main()
        {

            short input = short.Parse(Console.ReadLine());
            string inputToBinary = ShortToBinary(input);

            Console.WriteLine("{0}{1}", inputToBinary[0], inputToBinary.Substring(1, 15));
        }
        static string ShortToBinary(short number)
        {
            byte[] bytesInput = BitConverter.GetBytes(number); //number as an array of 4 bytes
            string inputToBinary = "";
            for (int i = 0; i < bytesInput.Length; i++) //convert each byte to its binary representation and pad
            { //with zeroes to get 8 bits for each byte
                inputToBinary = Convert.ToString(bytesInput[i], 2).PadLeft(8, '0') + inputToBinary;
            }
            return inputToBinary;
        }
    }
}
