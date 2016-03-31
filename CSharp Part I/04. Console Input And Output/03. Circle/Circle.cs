namespace _03.Circle
{
    using System;

    public class Circle
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area,
                    perimeter;

            area = Math.PI * r;
            perimeter = (2 * Math.PI) * r;

            Console.WriteLine("{} {1}", area, perimeter);
        }
    }
}
