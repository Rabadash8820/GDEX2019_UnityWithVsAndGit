using UnityEngine;

namespace CardGame {

    public class CardDealer {

        public Card[] Deal(int numCards, Suit suit) {
            var cards = new Card[numCards];

            for (int c = 0; c < numCards; ++c) {
                var value = (CardValue)Random.Range((int)CardValue.Two, (int)CardValue.Ace + 1);
                cards[c] = new Card(value, suit);
            }

            return cards;
        }

    }

}
