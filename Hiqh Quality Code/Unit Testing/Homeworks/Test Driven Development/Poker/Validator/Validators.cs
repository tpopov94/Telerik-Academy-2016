namespace Poker.Validator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Validators
    {
        public const int validCardsInHand = 5;

        public static void CheckCardsCount(IList<ICard> cards)
        {
            if (cards.Count > 5)
            {
                throw new ArgumentException("Poker hand must contain exactly 5 cards");
            }
        }

        public static void CheckIfHandContainsNull(IList<ICard> cards)
        {
            foreach (var card in cards)
            {
                if (card == null)
                {
                    throw new ArgumentNullException("Cards cannot be null");
                }
            }
        }

        public static void CheckIfCardsIsNull(IList<ICard> cards)
        {
            if (cards == null)
            {
                throw new ArgumentNullException("Cards cannot be null");
            }
        }

        public static void CheckForDuplicateCardsInHand(IHand hand)
        {
            if (hand.Cards.Distinct().Count() != validCardsInHand)
            {
                throw new ArgumentException("Duplicate cards.");
            }
        }

        public static void CheckCardsCountInHand(IHand hand)
        {
            if (hand.Cards.Count != validCardsInHand)
            {
                throw new ArgumentException("Cards in hand must be exactly five");
            }
        }

        public static bool IsFlush(IHand hand)
        {
            for (int i = 0; i < 4; i++)
            {
                if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsFourOfAKind(IHand hand)
        {
            int counter = 1;

            for (int i = 0; i < validCardsInHand-1; i++)
            {
                if (hand.Cards[i].Face == hand.Cards[i + 1].Face)
                {
                    counter++;
                }
            }
            if (counter == 4)
            {
                return true;
            }
            if (counter == 5)
            {
                throw new ArgumentException("There cannot be 5 cards with the same face");
            }
            return false;
        }

       
    }
}
