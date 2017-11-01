using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        Random random = new Random();
        private List<Card> deckOfCards = new List<Card>();
        List<int> listByColor = new List<int>();
        private int numberOfCards;
        string[] colorTypes = new string[] {"Club", "Diamond", "Heart", "Spade"};

        string[] valueTypes = new string[]
            {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};

        public Deck(int numberOfCards)
        {
            this.numberOfCards = numberOfCards;
            if (numberOfCards < 4)
            {
                MakeColorDifferent(numberOfCards);
            }
            else
            {
                MakeColorDifferent();
                while (listByColor.Count < numberOfCards)
                {
                    listByColor.Add(random.Next(0, 4));
                }
            }
            for (int i = 0; i < numberOfCards; i++)
            {
                deckOfCards.Add(new Card(colorTypes[listByColor[i]], valueTypes[random.Next(0, 13)]));
            }
            foreach (var card in deckOfCards)
            {
                Console.Write(card.GetCard() + " ");
            }
        }

        public List<Card> DeckOfCards
        {
            get { return deckOfCards; }
            set { deckOfCards = value; }
        }

        public void MakeColorDifferent()
        {
            for (int i = 0; i < 4; i++)
            {
                int suit = random.Next(0, 4);
                while (listByColor.Contains(suit))
                {
                    suit = random.Next(0, 4);
                }
                listByColor.Add(suit);
            }
        }

        public void MakeColorDifferent(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int suit = random.Next(0, 4);
                while (listByColor.Contains(suit))
                {
                    suit = random.Next(0, 4);
                }
                listByColor.Add(suit);
            }
        }

        public void ShuffleDeck()
        {
            List<int> deckOfShuffledCards = new List<int>();
            List<Card> shuffledDeck = new List<Card>();
            for (int i = 0; i < deckOfCards.Count; i++)
            {
                int indexOfCard = random.Next(0, deckOfCards.Count);
                while (deckOfShuffledCards.Contains(indexOfCard))
                {
                    indexOfCard = random.Next(0, deckOfCards.Count);
                }
                deckOfShuffledCards.Add(indexOfCard);
            }
            foreach (int index in deckOfShuffledCards)
            {
                shuffledDeck.Add(deckOfCards[index]);
            }
            for (int i = 0; i < deckOfCards.Count; i++)
            {
                deckOfCards[i] = shuffledDeck[i];
            }
            foreach (var card in deckOfCards)
            {
                Console.Write(card.GetCard() + " ");
            }
        }

        public Card DrawTopCard()
        {
            var cardDrawn = deckOfCards[0];
            deckOfCards.RemoveAt(0);
            return cardDrawn;
        }

        public void PrintOutDeck()
        {
            int diamond = 0;
            int club = 0;
            int heart = 0;
            int spade = 0;
            foreach (var card in deckOfCards)
            {
                if (card.GetColor() == "Diamond")
                {
                    diamond++;
                }
                else if (card.GetColor() == "Club")
                {
                    club++;
                }
                else if (card.GetColor() == "Heart")
                {
                    heart++;
                }
                else if (card.GetColor() == "Spade")
                {
                    spade++;
                }
            }
            Console.WriteLine("{0}cards - {1} Diamond, {2} Club, {3} Heart, {4} Spade", deckOfCards.Count, diamond,
                club, heart, spade);
        }
    }
}
