using System;
using System.Collections.Generic;

namespace TwentyPlusOne
{
    public class Deck
    {
        public List<Card> myDeck;

        public List<Card> GenerateMyDeck()
        {
            int NumberOfCardPackages = 2;
            var myDeck = new List<Card>();

            for (int i = 0; i < NumberOfCardPackages; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(SuitEnum)).Length; j++)
                {
                    for (int k = 0; k < Enum.GetNames(typeof(RankEnum)).Length; k++)
                    {
                        var card = new Card((SuitEnum)j, (RankEnum)k);
                        myDeck.Add(card);
                    }
                }
            }
            return myDeck;
        }
    }
}