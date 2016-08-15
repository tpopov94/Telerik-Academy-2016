using System;
using System.Collections.Generic;
using Poker.Validator;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            Validators.CheckIfCardsIsNull(cards);
            Validators.CheckIfHandContainsNull(cards);
            Validators.CheckCardsCount(cards);
            
            this.Cards = cards;
        }

        public override string ToString()
        {
            return string.Join(" ", this.Cards);
        }
    }
}
