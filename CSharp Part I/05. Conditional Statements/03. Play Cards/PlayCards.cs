// Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
// Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign or "no CONTENT_OF_STRING" otherwise.

namespace _03.Play_Cards
{
    using System;

    public class PlayCards
    {
        static void Main()
        {
            string input = Console.ReadLine();



            switch (input)
            {
                case "2": Console.WriteLine("yes {0}", input); break;
                case "3": Console.WriteLine("yes {0}", input); break;
                case "4": Console.WriteLine("yes {0}", input); break;
                case "5": Console.WriteLine("yes {0}", input); break;
                case "6": Console.WriteLine("yes {0}", input); break;
                case "7": Console.WriteLine("yes {0}", input); break;
                case "8": Console.WriteLine("yes {0}", input); break;
                case "9": Console.WriteLine("yes {0}", input); break;
                case "10": Console.WriteLine("yes {0}", input); break;
                case "J": Console.WriteLine("yes {0}", input.ToLower()); break;
                case "Q": Console.WriteLine("yes {0}", input.ToLower()); break;
                case "K": Console.WriteLine("yes {0}", input.ToLower()); break;
                case "A": Console.WriteLine("yes {0}", input.ToLower()); break;
                default:
                    Console.WriteLine("no {0}", input); break;
            }
        }
    }
}
