namespace _02.Moon_Gravity
{
    using System;

    public class MoonGravity
    {
        static void Main()
        {
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("{0:F3}", weight * 0.17);
        }
    }
}
