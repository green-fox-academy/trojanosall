using System;

namespace TwentyPlusOne
{
    class Card
    {
        private string cardSuit;
        private string cardRank;
        private static Random random = new Random();

        public Card()
        {
            cardSuit = GenerateRandomCardSuit();
            cardRank = GenerateRandomCardRank();
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
    }
}
