/*
    Define a class BitArray64 to hold 64 bit values inside an ulong value.
    Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
*/

namespace _64BitArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BitArrayMain
    {
        public static void Main()
        {
            var testNumber = new BitArray(254);

            // number as array of bits:

            Console.WriteLine(string.Join("", testNumber.ArrayOfBits));

            // check indexer

            Console.WriteLine(testNumber[12]);
            Console.WriteLine(testNumber[27]);

            // check enumerator

            foreach (var bit in testNumber)
            {
                Console.Write(bit);
            }

            Console.WriteLine();

            //check equals and ==

            var testNumber2 = new BitArray(12);
            var testNumber3 = new BitArray(245);

            Console.WriteLine(testNumber.Equals(testNumber2));
            Console.WriteLine(testNumber.Equals("10111011"));
            Console.WriteLine(testNumber.Equals(testNumber3));
            Console.WriteLine(testNumber == testNumber2);
            Console.WriteLine(testNumber != testNumber3);
        }
    }
}
