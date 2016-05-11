// Write program that calculates the surface of a triangle by given a side and an altitude to it.
namespace _04.Triangle_Surface_By_Side_And_Altitude
{
    using System;

    public class Program
    {
        static void Main()
        {
            decimal length = decimal.Parse(Console.ReadLine());
            decimal altitidue = decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", TriangleSurface(length, altitidue));
        }

        public static decimal TriangleSurface(decimal length, decimal altitidue)
        {
            decimal surface = ((length * altitidue) / 2);

            return surface;
        }
            
    }
}
