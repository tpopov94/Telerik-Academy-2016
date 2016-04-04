/*
Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
    The card faces should start from 2 to A.
    Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
*/

namespace _04.Print_A_Deck
{
    using System;

    public class PrintDeck
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            for (int i = 1; i < n; i++)
            {
                if (i > cards.Length)
                {
                    break;
                }
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cards[i-1]);
            }
        }
    }
}
