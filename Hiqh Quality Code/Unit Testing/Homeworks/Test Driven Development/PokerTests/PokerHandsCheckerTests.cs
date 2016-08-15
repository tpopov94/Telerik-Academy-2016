namespace PokerTests
{
    using System;
    using Poker;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class PokerHandsCheckerTests
    {
        [TestMethod]
        public void IsValidHand_PokerHandMustContainsExactlyFiveDifferentCards()
        {
            var listOfCard = new List<ICard>(){ new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Seven, CardSuit.Diamonds),
                                                new Card(CardFace.Seven,CardSuit.Hearts),
                                                new Card(CardFace.Ace,CardSuit.Hearts),
                                                new Card(CardFace.King,CardSuit.Clubs)};
            var hand = new Hand(listOfCard);
            var checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void IsValidHand_CheckerMustTrhowArgumentExceptionIfThereAreDublicateCards()
        {
            var listOfCard = new List<ICard>(){ new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Seven, CardSuit.Diamonds),
                                                new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Ace,CardSuit.Hearts),
                                                new Card(CardFace.King,CardSuit.Clubs)};
            var hand = new Hand(listOfCard);
            var neewList = hand.Cards.Distinct();
            var checker = new PokerHandsChecker();
            Assert.ThrowsException<ArgumentException>(() => checker.IsValidHand(hand));
        }

        [TestMethod]
        public void IsValidHand_CheckerMustThrowArgumentNullExceptionIfHandIsNull()
        {
            var checker = new PokerHandsChecker();
            Assert.ThrowsException<ArgumentNullException>(() => checker.IsValidHand(null));
        }

        [TestMethod]
        public void IsValidHand_CheckerMustThrowArgumentExceptionIfTheCardsInTheHandAreDifferentThanFive()
        {
            var listOfCard = new List<ICard>() { new Card(CardFace.Eight, CardSuit.Hearts) };
            var hand = new Hand(listOfCard);
            var checker = new PokerHandsChecker();

            Assert.ThrowsException<ArgumentException>(() => checker.IsValidHand(hand));
        }

        [TestMethod]
        public void IsValidHand_CheckerMustTrhowArgumentExceptionIfThereAreFiveCardsFromTheSameFace()
        {
            var listOfCard = new List<ICard>(){ new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Eight, CardSuit.Diamonds),
                                                new Card(CardFace.Eight,CardSuit.Clubs),
                                                new Card(CardFace.Eight,CardSuit.Spades),
                                                new Card(CardFace.Eight,CardSuit.Clubs)};
            var hand = new Hand(listOfCard);
            var neewList = hand.Cards.Distinct();
            var checker = new PokerHandsChecker();
            Assert.ThrowsException<ArgumentException>(() => checker.IsValidHand(hand));
        }

        [TestMethod]
        public void IsFlush_ShouldThrowArgmunetNullExceptionIfTheHandIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Hand(null));
        }

        [TestMethod]
        public void IsFlush_ShouldThrowArgumentExceptionIfGivenLessThanFiveValidCards()
        {
            var listOfCards = new List<ICard>() {
                                                new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Seven,CardSuit.Clubs)};
            var checker = new PokerHandsChecker();
            Assert.ThrowsException<ArgumentException>(() => checker.IsFlush(new Hand(listOfCards)));
        }

        [TestMethod]
        public void IsFlush_ShouldReturnFalseIfTheHandIsValidButNotFlush()
        {
            var listOfCards = new List<ICard>() {
                                                new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Eight, CardSuit.Diamonds),
                                                new Card(CardFace.Ace,CardSuit.Clubs),
                                                new Card(CardFace.Eight,CardSuit.Spades),
                                                new Card(CardFace.Seven,CardSuit.Clubs)};
            var checker = new PokerHandsChecker();
            Assert.IsFalse(checker.IsFlush(new Hand(listOfCards)));
        }

        [TestMethod]
        public void IsFlush_ShouldReturnTrueIfTheHandIsValidWithFiveCardsFromTheSameSuit()
        {
            var listOfCards = new List<ICard>() {
                                                new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Eight, CardSuit.Hearts),
                                                new Card(CardFace.Ace,CardSuit.Hearts),
                                                new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Seven,CardSuit.Hearts)};
            var checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsFlush(new Hand(listOfCards)));
        }

        [TestMethod]
        public void IsFourOfAKind_ShouldReturnFalseIfThrereAreLessThanFourSameValidCards()
        {
            var listOfCards = new List<ICard>() {
                                                new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Eight, CardSuit.Hearts),
                                                new Card(CardFace.Ace,CardSuit.Hearts),
                                                new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Seven,CardSuit.Spades)};
            var checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFourOfAKind(new Hand(listOfCards)));
        }

        [TestMethod]
        public void IsFourOfAKind_ShouldReturnTrueIfThereAreFourSameFaceCards()
        {
            var listOfCards = new List<ICard>() {
                                                new Card(CardFace.Eight,CardSuit.Spades),
                                                new Card(CardFace.Eight, CardSuit.Clubs),
                                                new Card(CardFace.Eight,CardSuit.Diamonds),
                                                new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Seven,CardSuit.Spades)};
            var checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFourOfAKind(new Hand(listOfCards)));
        }

        [TestMethod]
        public void IsFourOfAKind_ShouldThrowArgumentExceptionIfThereAreFiveCardsWithTheSameFace()
        {
            var listOfCards = new List<ICard>() {
                                                new Card(CardFace.Eight,CardSuit.Spades),
                                                new Card(CardFace.Eight, CardSuit.Clubs),
                                                new Card(CardFace.Eight,CardSuit.Diamonds),
                                                new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Eight,CardSuit.Spades)};
            var checker = new PokerHandsChecker();

            Assert.ThrowsException<ArgumentException>(() => checker.IsFourOfAKind(new Hand(listOfCards)));
        }

        [TestMethod]
        public void IsOnePair_ShouldReturnTrueIfThereIsOnlyOnePairInTheHand()
        {
            var listOfCards = new List<ICard>() {
                                                new Card(CardFace.Eight,CardSuit.Spades),
                                                new Card(CardFace.Nine, CardSuit.Clubs),
                                                new Card(CardFace.Six,CardSuit.Diamonds),
                                                new Card(CardFace.Eight,CardSuit.Hearts),
                                                new Card(CardFace.Seven,CardSuit.Spades)};
            var checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsOnePair(new Hand(listOfCards)));
        }

        [TestMethod]
        public void IsOnePair_ShouldReturnFalseIfThereIsMoreThanOnePairInTheHand()
        {
            var listOfCards = new List<ICard>() {
                                                new Card(CardFace.Eight,CardSuit.Spades),
                                                new Card(CardFace.Nine, CardSuit.Clubs),
                                                new Card(CardFace.Six,CardSuit.Diamonds),
                                                new Card(CardFace.Nine,CardSuit.Hearts),
                                                new Card(CardFace.Eight,CardSuit.Spades)};
            var checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsOnePair(new Hand(listOfCards)));
        }
    }
}
