namespace Poker
{
    using System;
    using System.Linq;
    using Validator;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public const int validCardsInHand = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Hand cannot be null.");
            }

            Validators.CheckCardsCountInHand(hand);

            Validators.CheckForDuplicateCardsInHand(hand);

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            Validators.CheckCardsCountInHand(hand);

            return Validators.IsFourOfAKind(hand);
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            Validators.CheckCardsCountInHand(hand);

            return Validators.IsFlush(hand);
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            var group = hand.Cards.GroupBy(card => card.Face);
            return group.Count(gr => gr.Count() == 2) == 1 && !group.Any(gr => gr.Count() == 3);
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
