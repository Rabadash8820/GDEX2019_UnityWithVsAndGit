namespace Cards {
    public struct Card {

        public Card(CardValue value, Suit suit) : this(suit, value) { }
        public Card(Suit suit, CardValue value) {
            Value = value;
            Suit = suit;
        }

        public CardValue Value;
        public Suit Suit;

        public override string ToString() => $"{Value} of {Suit}";
    }
}
