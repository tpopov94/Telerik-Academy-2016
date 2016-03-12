namespace DivisableBySevenAndThree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in
    //extension methods and lambda expressions. Rewrite the same with LINQ.

    class DivisableMain
    {
        static void Main() // Task 6
        {

            var arrayOfInts = new int[] { 1, 21, 33, 63, 4, 5, 1603, 3457, 3, 14, 144, 3454352, 342, 3241, 240 };

            var divisableExtMeth = arrayOfInts.Where(n => n % 3 == 0 && n % 7 == 0).ToList();

            Console.WriteLine("Numbers that are divisable by 7 and 3 (Lambda):");

            foreach (var item in divisableExtMeth)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
            var divisableLinq =
                from n in arrayOfInts
                where (n % 3 == 0 && n % 7 == 0)
                select n;

            Console.WriteLine("Numbers, divisible by 3 and 7 (using LINQ):\n{0}", string.Join(", ", divisableLinq));
        }
    }
}
