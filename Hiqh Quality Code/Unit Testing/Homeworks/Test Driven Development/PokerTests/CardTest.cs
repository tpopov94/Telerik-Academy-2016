namespace PokerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Poker;

    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void ToString_ShouldNotPrintIfOneOfTheValuesIsNull()
        {
            // Arrange
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            var expected = "Ace of Clubs!";

            Assert.AreEqual( expected, card.ToString(), "To string is not returning correct values");
        }
    }
}
