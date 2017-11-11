using System;
using System.Collections.Generic;

namespace TwentyPlusOne
{
    public class Game
    {
        public Deck GameDeck;
        public List<Card> PlayerCards;
        public int OponentScore;
        public int BlackJackValue = 21;
        public int MinOponenPoints = 15;
        static readonly Random RandomNumber = new Random();

        public int GetOponentScore()
        {
            OponentScore = RandomNumber.Next(MinOponenPoints, BlackJackValue);

            return OponentScore;
        }

        public List<Card> GetPlayerCards(List<Card> actualGameDeck)
        {
            PlayerCards = new List<Card>();
            Card FirstPlayerCard = GameDeck.PullFirst(actualGameDeck);
            PlayerCards.Add(FirstPlayerCard);
            Card LastPlayerCard = GameDeck.PullLast(actualGameDeck);
            PlayerCards.Add(LastPlayerCard);

            return PlayerCards;
        }

    }
}
