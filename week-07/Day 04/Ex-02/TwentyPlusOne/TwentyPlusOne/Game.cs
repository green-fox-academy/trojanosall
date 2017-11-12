using System;
using System.Collections.Generic;

namespace TwentyPlusOne
{
    public class Game
    {
        public List<Card> GameDeck;
        public Deck MyDeck;
        public List<Card> PlayerCards;
        public int OponentScore { get; set; }
        public int BlackJackValue = 21;
        public int MinOponenPoints = 15;
        static readonly Random RandomNumber = new Random();

        public Game()
        {
            GameDeck = GetGameDeck();
        }

        public int GetOponentScore()
        {
            OponentScore = RandomNumber.Next(MinOponenPoints, BlackJackValue);

            return OponentScore;
        }

        public List<Card> GetGameDeck()
        {
            List<Card> GameDeck = MyDeck.ShuffleDeck(MyDeck.GenerateMyDeck());

            return GameDeck;

        }

        public List<Card> GetNewCard(List<Card> playerCards, List<Card> gameDeck)
        {
            playerCards.Add(MyDeck.PullRandom(gameDeck));

            return playerCards;
        }

        public int GetTotalValueOfPlayerCards(List<Card> playerCards)
        {
            int TotalValueOfPlayerCards = 0;
            foreach (var cards in playerCards)
            {
                TotalValueOfPlayerCards += cards.CardValue;
            }
            return TotalValueOfPlayerCards;
        }


        public List<Card> GetInitialPlayerCards(List<Card> GameDeck)
        {
            PlayerCards = new List<Card>();
            Card FirstPlayerCard = MyDeck.PullFirst(GameDeck);
            PlayerCards.Add(FirstPlayerCard);
            Card LastPlayerCard = MyDeck.PullLast(GameDeck);
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

        public void StartGame()
        {
            Console.WriteLine($"Welcome to My Black Jack Game!");

            List<Card> actualGameDeck = GameDeck;

            List<Card> PlayerCards = GetInitialPlayerCards(actualGameDeck);

            PrintActualPlayerCardsAndPoints(PlayerCards);

        }

        public void PlayGame()
        {
            OponentScore = GetOponentScore();
            Console.WriteLine($"\n The value of cards of Bank is the following: {OponentScore}");

            Console.WriteLine("Do you want to hit or stand? Please type H or S!");

            string input = Console.ReadLine().ToLower();

            if (input == "s")
            {
                GameOver();
            }
            else if (input == "h")
            {
                GetNewCard(PlayerCards, GameDeck);
                PrintActualPlayerCardsAndPoints(PlayerCards);
                LoseOrContinue();
            }
            else
                Console.WriteLine("You typed a wrong character, please type H or S!");
            PlayGame();
        }

        public void LoseOrContinue()
        {
            if (GetTotalValueOfPlayerCards(PlayerCards) <= 21)
            {
                PlayGame();
            }
            else if (GetTotalValueOfPlayerCards(PlayerCards) > 21)
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            int TotalValueOfPlayerCards = 0;
            foreach (var cards in PlayerCards)
            {
                TotalValueOfPlayerCards += cards.CardValue;
            }

            if ((TotalValueOfPlayerCards <= 21) && (TotalValueOfPlayerCards > OponentScore))
            {
                Console.WriteLine("You won!!!");
            }
            else if ((TotalValueOfPlayerCards < OponentScore) || (TotalValueOfPlayerCards > 21))
            {
                Console.WriteLine("You lost!!!");
            }
            else if (TotalValueOfPlayerCards == OponentScore)
            {
                Console.WriteLine("It's a score draw!");
            }
        }
    }

}

