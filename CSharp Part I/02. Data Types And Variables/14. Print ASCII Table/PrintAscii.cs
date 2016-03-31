namespace _14.Print_ASCII_Table
{
    using System;

    public class PrintAscii
    {
        static void Main()
        {
            
            for (int i = 33; i < 127; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
