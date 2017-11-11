using System.Collections.Generic;

namespace TwentyPlusOne
{
    public class Card
    {
        public SuitEnum CardSuit { get; set; }
        public RankEnum CardRank { get; set; }
        public string CardName { get; set; }
        public int CardValue { get; set; }



        public Card(SuitEnum cardSuit, RankEnum cardRank)
        {
            CardSuit = cardSuit;
            CardRank = cardRank;
            CardName = CardSuit + " " + CardRank;
            CardValue = GetCardValue();
        }

        public int GetCardValue()
        {
            Dictionary<object, int> CardRankAndCardValueMapping = new Dictionary<object, int>()
        {
            {RankEnum.Two, 2},
            {RankEnum.Three, 3},
            {RankEnum.Four, 4},
            {RankEnum.Five, 5},
            {RankEnum.Six, 6},
            {RankEnum.Seven, 7},
            {RankEnum.Eight, 8},
            {RankEnum.Nine, 9},
            {RankEnum.Ten, 10},
            {RankEnum.Jack, 10},
            {RankEnum.Queen, 10},
            {RankEnum.King, 10},
            {RankEnum.Ace, 11},
        };

            int CardValue = CardRankAndCardValueMapping[CardRank];
            return CardValue;
        }
    }
}
