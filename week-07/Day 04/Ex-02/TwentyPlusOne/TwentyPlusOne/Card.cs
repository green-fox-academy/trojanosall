using System;
using System.Collections.Generic;

namespace TwentyPlusOne
{
    class Card
    {
        public string CardSuit { get; set; }
        public string CardRank { get; set; }
        public string CardName { get; set; }
        public int CardValue { get; set; }
        public Dictionary<string, int> CardRankAndCardValueMapping = new Dictionary<string, int>()
        {
            {RankEnum.Two.ToString(), 2},
            {RankEnum.Three.ToString(), 3},
            {RankEnum.Four.ToString(), 4},
            {RankEnum.Five.ToString(), 5},
            {RankEnum.Six.ToString(), 6},
            {RankEnum.Seven.ToString(), 7},
            {RankEnum.Eight.ToString(), 8},
            {RankEnum.Nine.ToString(), 9},
            {RankEnum.Ten.ToString(), 10},
            {RankEnum.Jack.ToString(), 10},
            {RankEnum.Queen.ToString(), 10},
            {RankEnum.King.ToString(), 10},
            {RankEnum.Ace.ToString(), 11},
        };
        private static Random random = new Random();

        public Card()
        {
            CardSuit = GenerateRandomCardSuit();
            CardRank = GenerateRandomCardRank();
            CardName = CardSuit + " " + CardRank;
            CardValue = GetCardValue();
        }

        public string GenerateRandomCardSuit()
        {
            Array SuitEnumValues = Enum.GetValues(typeof(SuitEnum));
            SuitEnum RandomCardSuit = (SuitEnum)SuitEnumValues.GetValue(random.Next(SuitEnumValues.Length));
            return RandomCardSuit.ToString();
        }

        public string GenerateRandomCardRank()
        {
            Array RankEnumValues = Enum.GetValues(typeof(RankEnum));
            RankEnum RandomCardRank = (RankEnum)RankEnumValues.GetValue(random.Next(RankEnumValues.Length));
            return RandomCardRank.ToString();
        }

        public int GetCardValue()
        {
            int CardValue = CardRankAndCardValueMapping[CardRank];
            return CardValue;
        }
    }
}
