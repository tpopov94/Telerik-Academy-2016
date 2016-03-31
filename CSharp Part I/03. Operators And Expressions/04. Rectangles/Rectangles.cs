namespace _04.Rectangles
{
    using System;

    public class Rectangles
    {
        static void Main()
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float area, perimeter;

            area = width * height;
            perimeter = (2 * width) + (2 * height);

            Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
        }
    }
}
