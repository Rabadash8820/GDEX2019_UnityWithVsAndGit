using Cards;
using System;
using UnityEngine;

namespace CardGame {
    [CreateAssetMenu(fileName = nameof(CardSprites), menuName = nameof(CardGame) + "/" + nameof(CardSprites))]
    public class CardSprites : ScriptableObject {
        public Sprite TwoClubs;
        public Sprite TwoSpades;
        public Sprite TwoHearts;
        public Sprite TwoDiamonds;

        public Sprite ThreeClubs;
        public Sprite ThreeSpades;
        public Sprite ThreeHearts;
        public Sprite ThreeDiamonds;

        public Sprite FourClubs;
        public Sprite FourSpades;
        public Sprite FourHearts;
        public Sprite FourDiamonds;

        public Sprite FiveClubs;
        public Sprite FiveSpades;
        public Sprite FiveHearts;
        public Sprite FiveDiamonds;

        public Sprite SixClubs;
        public Sprite SixSpades;
        public Sprite SixHearts;
        public Sprite SixDiamonds;

        public Sprite SevenClubs;
        public Sprite SevenSpades;
        public Sprite SevenHearts;
        public Sprite SevenDiamonds;

        public Sprite EightClubs;
        public Sprite EightSpades;
        public Sprite EightHearts;
        public Sprite EightDiamonds;

        public Sprite NineClubs;
        public Sprite NineSpades;
        public Sprite NineHearts;
        public Sprite NineDiamonds;

        public Sprite TenClubs;
        public Sprite TenSpades;
        public Sprite TenHearts;
        public Sprite TenDiamonds;

        public Sprite JackClubs;
        public Sprite JackSpades;
        public Sprite JackHearts;
        public Sprite JackDiamonds;

        public Sprite QueenClubs;
        public Sprite QueenSpades;
        public Sprite QueenHearts;
        public Sprite QueenDiamonds;

        public Sprite KingClubs;
        public Sprite KingSpades;
        public Sprite KingHearts;
        public Sprite KingDiamonds;

        public Sprite AceClubs;
        public Sprite AceSpades;
        public Sprite AceHearts;
        public Sprite AceDiamonds;

        public Sprite Get(CardValue value, Suit suit) => Get(suit, value);
        public Sprite Get(Suit suit, CardValue value)
        {
            switch (suit) {
                case Suit.Clubs:
                    switch (value) {
                        case CardValue.Two: return TwoClubs;
                        case CardValue.Three: return ThreeClubs;
                        case CardValue.Four: return FourClubs;
                        case CardValue.Five: return FiveClubs;
                        case CardValue.Six: return SixClubs;
                        case CardValue.Seven: return SevenClubs;
                        case CardValue.Eight: return EightClubs;
                        case CardValue.Nine: return NineClubs;
                        case CardValue.Ten: return TenClubs;
                        case CardValue.Jack: return JackClubs;
                        case CardValue.Queen: return QueenClubs;
                        case CardValue.King: return KingClubs;
                        case CardValue.Ace: return AceClubs;
                    }
                    break;

                case Suit.Spades:
                    switch (value) {
                        case CardValue.Two: return TwoSpades;
                        case CardValue.Three: return ThreeSpades;
                        case CardValue.Four: return FourSpades;
                        case CardValue.Five: return FiveSpades;
                        case CardValue.Six: return SixSpades;
                        case CardValue.Seven: return SevenSpades;
                        case CardValue.Eight: return EightSpades;
                        case CardValue.Nine: return NineSpades;
                        case CardValue.Ten: return TenSpades;
                        case CardValue.Jack: return JackSpades;
                        case CardValue.Queen: return QueenSpades;
                        case CardValue.King: return KingSpades;
                        case CardValue.Ace: return AceSpades;
                    }
                    break;

                case Suit.Hearts:
                    switch (value) {
                        case CardValue.Two: return TwoHearts;
                        case CardValue.Three: return ThreeHearts;
                        case CardValue.Four: return FourHearts;
                        case CardValue.Five: return FiveHearts;
                        case CardValue.Six: return SixHearts;
                        case CardValue.Seven: return SevenHearts;
                        case CardValue.Eight: return EightHearts;
                        case CardValue.Nine: return NineHearts;
                        case CardValue.Ten: return TenHearts;
                        case CardValue.Jack: return JackHearts;
                        case CardValue.Queen: return QueenHearts;
                        case CardValue.King: return KingHearts;
                        case CardValue.Ace: return AceHearts;
                    }
                    break;

                case Suit.Diamonds:
                    switch (value) {
                        case CardValue.Two: return TwoDiamonds;
                        case CardValue.Three: return ThreeDiamonds;
                        case CardValue.Four: return FourDiamonds;
                        case CardValue.Five: return FiveDiamonds;
                        case CardValue.Six: return SixDiamonds;
                        case CardValue.Seven: return SevenDiamonds;
                        case CardValue.Eight: return EightDiamonds;
                        case CardValue.Nine: return NineDiamonds;
                        case CardValue.Ten: return TenDiamonds;
                        case CardValue.Jack: return JackDiamonds;
                        case CardValue.Queen: return QueenDiamonds;
                        case CardValue.King: return KingDiamonds;
                        case CardValue.Ace: return AceDiamonds;
                    }
                    break;
            }

            throw new NotImplementedException($"Gah! We haven't accounted for value {value}, suit {suit}!");
        }
    }
}
