using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Card class, that has a color and a value
            // Create a constructor for setting those values
            // Card should be represented as string in this format:
            // 9 Hearts
            // Jack Diamonds
            // Create a Deck class, that has a list of cards in it
            // Create a constructor that takes a whole number as parameter
            // The constructor should fill the list with the number of different cards using at least 4 different colors (except if the number given is smaller than four, than all cards should have different colors)
            // We should be able to shuffle the deck, which randomly orders the cards
            // We should be able to draw the top card which returns the drawn card and also removes it from the deck
            // Deck should be represented as string in this format:
            // 12 cards -  3 Clubs, 3 Diamonds, 3 Hearts, 3 Spades
            Deck deck = new Deck(12);
            Console.WriteLine();
            deck.ShuffleDeck();
            var topCard = deck.DrawTopCard();
            Console.WriteLine();
            Console.WriteLine(topCard.GetCard());
            Console.WriteLine();
            foreach (var card in deck.DeckOfCards)
            {
                Console.Write(card.GetCard() + " ");
            }
            Console.WriteLine();
            deck.PrintOutDeck();

            Console.ReadLine();
        }
    }
}
    