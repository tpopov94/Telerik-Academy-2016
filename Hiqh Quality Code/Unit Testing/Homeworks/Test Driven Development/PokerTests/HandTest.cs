namespace PokerTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Poker;

    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void ToString_ShouldDisplayCorrectResult()
        {
            var listOfCard = new List<ICard>(){ new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Seven, CardSuit.Diamonds)};
            var hand = new Hand(listOfCard);
            var expected = "Eight of Hearts! Seven of Diamonds!";

            Assert.AreEqual(expected, hand.ToString(), "Hand to string does not display the cards in the hand properly");
        }

        [TestMethod]
        public void ToString_ShouldThrowArgumentNullExceptionIfCardsAreNull()
        {
            Assert.ThrowsException<ArgumentNullException>(()=> new Hand(null));
        }

        // Poker hand contains of no more than 5 cards (2 in the hand + 3 on the table or 5 in the hand(check wikipedia))
        [TestMethod]
        public void HandMustContainNoMoreThanFiveCardsAndShouldThrowArgumentExceptionIfThereAreMoreCards()
        {
            var listOfCard = new List<ICard>(){ new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Seven, CardSuit.Diamonds),
                                                new Card(CardFace.Seven, CardSuit.Clubs),
                                                new Card(CardFace.Five, CardSuit.Clubs),
                                                new Card(CardFace.Ace, CardSuit.Diamonds),
                                                new Card(CardFace.King, CardSuit.Diamonds)};
            Assert.ThrowsException<ArgumentException>(() => new Hand(listOfCard));
        }

        [TestMethod]
        public void ToString_ShouldThrowArgumentNullExceptionIfAnyOfTheCardsIsNull()
        {
            var listOfCard = new List<ICard>(){ new Card(CardFace.Eight,CardSuit.Hearts), null};

            Assert.ThrowsException<ArgumentNullException>(() => new Hand(listOfCard));
        }
    }
}
