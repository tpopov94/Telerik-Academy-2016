namespace _06.Quadratic_Equation
{
    using System;

    public class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double descriminant,
                    x1,
                    x2;

            descriminant = (2 * b) - (4 * a * c);

            if(descriminant > 0)
            {
                x1 = (-b + Math.Sqrt(descriminant) / (2 * a));
                x2 = (-b - Math.Sqrt(descriminant) / (2 * a));
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else if (descriminant == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine(x1);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
