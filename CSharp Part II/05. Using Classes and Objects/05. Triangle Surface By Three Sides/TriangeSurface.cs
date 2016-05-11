// Write program that calculates the surface of a triangle by given its three sides.
namespace _05.Triangle_Surface_By_Three_Sides
{
    using System;

    public class TriangeSurface
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", TriangeSurfaceByThreeSides(sideA, sideB, sideC));
        }

        public static double TriangeSurfaceByThreeSides(double sideA, double sideB, double sideC)
        {
            double surface = 0;
            double area = (sideA + sideB + sideC) / 2;

            surface = Math.Sqrt(area * (area - sideA) * (area - sideB) * (area - sideC));
            return surface;
        }
    }
}
