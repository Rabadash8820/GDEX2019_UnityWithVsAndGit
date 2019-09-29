using NUnit.Framework;
using System;
using System.Linq;

namespace Cards.Test
{
    public class CardDealerTest
    {

        [Parallelizable]
        [Test(TestOf = typeof(CardDealer))]
        public void CanDealZeroCards() => testDeal(new CardDealer(), 0);

        [Parallelizable]
        [Test(TestOf = typeof(CardDealer))]
        public void CanDealMultipleCards() {
            var cardDealer = new CardDealer();

            testDeal(cardDealer, -1);
            testDeal(cardDealer, 2);
            testDeal(cardDealer, 5);
        }

        [Parallelizable]
        [Test(TestOf = typeof(CardDealer))]
        public void CannotDealNegativeCards() {
            var cardDealer = new CardDealer();

            Assert.Throws<ArgumentOutOfRangeException>(() => cardDealer.Deal(-1, Suit.Clubs));
            Assert.Throws<ArgumentOutOfRangeException>(() => cardDealer.Deal(-1, Suit.Spades));
            Assert.Throws<ArgumentOutOfRangeException>(() => cardDealer.Deal(-1, Suit.Hearts));
            Assert.Throws<ArgumentOutOfRangeException>(() => cardDealer.Deal(-1, Suit.Diamonds));

            Assert.Throws<ArgumentOutOfRangeException>(() => cardDealer.Deal(-5, Suit.Clubs));
            Assert.Throws<ArgumentOutOfRangeException>(() => cardDealer.Deal(-5, Suit.Spades));
            Assert.Throws<ArgumentOutOfRangeException>(() => cardDealer.Deal(-5, Suit.Hearts));
            Assert.Throws<ArgumentOutOfRangeException>(() => cardDealer.Deal(-5, Suit.Diamonds));
        }

        private void testDeal(CardDealer cardDealer, int numCards) {
            var suits = Enum.GetValues(typeof(Suit)).Cast<Suit>();
            foreach (Suit suit in suits) {
                Card[] cards = cardDealer.Deal(numCards, suit);
                Assert.That(cards.Length, Is.EqualTo(numCards));
                for (int c = 0; c < numCards; ++c)
                    Assert.That(cards[c].Suit, Is.EqualTo(suit));
            }
        }
    }
}
