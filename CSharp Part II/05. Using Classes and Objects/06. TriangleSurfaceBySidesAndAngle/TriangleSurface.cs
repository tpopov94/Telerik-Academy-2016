//Write program that calculates the surface of a triangle by given two sides and an angle between them.
// Formula S = ((a * B) / 2) * sin(angle)
namespace _06.TriangleSurfaceBySidesAndAngle
{
    using System;

    public class TriangleSurface
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine()); // angle is given in degrees

            Console.WriteLine("{0:F2}", TriangleSurfaceBySidesAndAngles(sideA, sideB, angle));
        }

        public static double TriangleSurfaceBySidesAndAngles(double sideA, double sideB, double angle)
        {
            double angleInRadians = angle * Math.PI / 180;
            double surface = ((sideA * sideB) / 2) * Math.Sin(angleInRadians); // Math.Sin works with radians

            return surface;
        }
    }
}
