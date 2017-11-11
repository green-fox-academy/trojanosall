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

        public List<Card> GetActualGameDeck()
        {
            List<Card> actualGameDeck = GameDeck.ShuffleDeck(GameDeck.GenerateMyDeck());
            return actualGameDeck;
        }


        public List<Card> GetInitialPlayerCards(List<Card> actualGameDeck)
        {
            PlayerCards = new List<Card>();
            Card FirstPlayerCard = GameDeck.PullFirst(actualGameDeck);
            PlayerCards.Add(FirstPlayerCard);
            Card LastPlayerCard = GameDeck.PullLast(actualGameDeck);
            PlayerCards.Add(LastPlayerCard);

            return PlayerCards;
        }

        public void PrintActualPlayerCardsAndPoints(List<Card> playerCards)
        {
            Console.WriteLine("\nYour cards are the following:");
            foreach (var cards in playerCards)
            {
                Console.WriteLine(cards.CardName);
            }

            Console.WriteLine("\nThe value of your cards is the following:");

            int TotalValueOfPlayerCards = 0;
            foreach (var cards in playerCards)
            {
                TotalValueOfPlayerCards += cards.CardValue;
            }
        }
    }
}
