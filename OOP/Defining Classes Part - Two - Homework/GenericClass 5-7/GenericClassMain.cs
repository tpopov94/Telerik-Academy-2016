namespace GenericClass_5_7
{
    using System;

    class GenericClassMain
    {
        static void Main()
        {
            var test = new GenericList<int>();

            for (int i = 0; i < 11; i++)
            {
                test.Add(i);
            }
            Console.WriteLine(test.ToString());

            test.AddAtIndex(4,56);

            Console.WriteLine(test.ToString());

            Console.WriteLine(test.Max());   // Testing Min and Max methods Task 7
            Console.WriteLine(test.Min());
        }
    }
}
