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
        }

        public object GenerateRandomCardSuit()
        {
            Array SuitEnumValues = Enum.GetValues(typeof(SuitEnum));            
            SuitEnum RandomCardSuit = (SuitEnum)SuitEnumValues.GetValue(random.Next(SuitEnumValues.Length));
            return RandomCardSuit;
        }
    }
}
