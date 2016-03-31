namespace _04.Floating_Numbers
{
    using System;

    public class FormatingNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("{0,10:X}|{3}|{1,10:F2}|{2,-10:F3}|", 
                a, b, c, Convert.ToString(a, 2).PadLeft(10, '0'));
        }
    }
}
