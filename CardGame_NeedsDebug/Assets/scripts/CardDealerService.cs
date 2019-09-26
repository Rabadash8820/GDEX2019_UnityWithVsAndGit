using System.Collections.Generic;
using UnityEngine;

namespace CardGame {

    public class CardDealerService : MonoBehaviour {

        private readonly CardDealer _cardDealer = new CardDealer();
        private readonly List<CardObject> _cards = new List<CardObject>();

        public Transform CardsRoot;
        public CardSprites CardSprites;

        private void Start() {
            CardsRoot.GetComponentsInChildren(_cards);
            var randSuit = (Suit)Random.Range(0, 4);
            redeal(randSuit);
        }

        public void RedealClubs() => redeal(Suit.Clubs);
        public void RedealSpades() => redeal(Suit.Spades);
        public void RedealHearts() => redeal(Suit.Hearts);
        public void RedealDiamonds() => redeal(Suit.Diamonds);

        private void redeal(Suit suit) {
            Card[] randCards = _cardDealer.Deal(_cards.Count, suit);
            for (int c = 0; c < _cards.Count; c++) {
                _cards[c].FrontImage.sprite = CardSprites.Get(randCards[c].Value, suit);
            }
        }

    }

}
