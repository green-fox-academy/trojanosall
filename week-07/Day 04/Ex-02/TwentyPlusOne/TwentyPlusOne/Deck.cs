using System;
using System.Collections.Generic;

namespace TwentyPlusOne
{
    public class Deck
    {
        public List<Card> myDeck;

        static readonly Random RandomNumber = new Random();

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

        public List<Card> ShuffleDeck(List<Card> shuffledCards)
        {
            int n = shuffledCards.Count;
            while (n > 1)
            {
                n--;
                int k = RandomNumber.Next(n + 1);
                Card temporary = shuffledCards[k];
                shuffledCards[k] = shuffledCards[n];
                shuffledCards[n] = temporary;
            }
            return shuffledCards;
        }

        public Card PullFirst(List<Card> shuffledCards)
        {
            Card FirstPulledCard = shuffledCards[0];
            shuffledCards.Remove(FirstPulledCard);

            return FirstPulledCard;
        }
    }
}