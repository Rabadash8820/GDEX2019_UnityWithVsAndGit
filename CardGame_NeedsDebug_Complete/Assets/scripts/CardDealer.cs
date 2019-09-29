using System;

namespace Cards {

    public class CardDealer {

        private readonly Random _rand = new Random();

        public Card[] Deal(int numCards, Suit suit) {
            var cards = new Card[numCards];

            for (int c = 0; c < numCards; ++c) {
                var value = (CardValue)_rand.Next((int)CardValue.Two, (int)CardValue.Ace + 1);
                cards[c] = new Card(value, suit);
            }

            return cards;
        }

    }

}
