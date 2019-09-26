using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardGame {


    public class CardDealerService : MonoBehaviour {

        private readonly CardDealer _cardDealer = new CardDealer();
        private readonly List<CardObject> _cards = new List<CardObject>();

        public Transform CardsRoot;
        public CardSprites CardSprites;

        void Start() {
            CardsRoot.GetComponentsInChildren(_cards);
            var randSuit = (Suit)Random.Range(0, 4);
            Card[] randCards = _cardDealer.Deal(_cards.Count, randSuit);
            for (int c = 0; c < _cards.Count; c++) {
                _cards[c].FrontImage.sprite = CardSprites.Get(randCards[c].Value, randSuit);
            }
        }
    }

}
