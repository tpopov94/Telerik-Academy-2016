namespace _03.Play_Cards
{
    using System;

    public class PlayCards
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());



            switch (input)
            {
                case 2: Console.WriteLine("yes {0}", input); break;
                case 3: Console.WriteLine("yes {0}", input); break;
                case 4: Console.WriteLine("yes {0}", input); break;
                case 5: Console.WriteLine("yes {0}", input); break;
                case 6: Console.WriteLine("yes {0}", input); break;
                case 7: Console.WriteLine("yes {0}", input); break;
                case 8: Console.WriteLine("yes {0}", input); break;
                case 9: Console.WriteLine("yes {0}", input); break;
                case 10: Console.WriteLine("yes {0}", input); break;
                default:
                    Console.WriteLine("no {0}", input); break;
            }
        }
    }
}
