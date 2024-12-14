using System;
using System.Collections.Generic;
using System.Reflection;

namespace TopTrumps
{
    // The Player class represents a player in the game.
    public class Player
    {
        // Variables and Data Structures: Properties representing the player's name, hand of cards, and score.
        public string Name { get; set; } // Name of the player
        public List<Card> Hand { get; private set; } // List of cards the player holds
        public int Score { get; set; } // Players Score
        

        //Constructor to intialize the player with a name and an empty hand of cards
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
            Score = 0;
        }

        // Procedures: Add a card to the player's hand
        public void AddCard(Card card)
        {
            Hand.Add(card);
        }

        // Procedures : Remove and return the top card from the player's hand.
        public Card PlayCard()
        {
            if(Hand.Count > 0)
            {
                Card card = Hand[0];
                Hand.RemoveAt(0);
                return card;
            }
            else
            {
                return null; //Return null if no cards are left.
            }
        }

        //Input/Output: Display the player's current hand.
        public void DisplayHand()
        {
            Console.WriteLine($"{Name}'s Hand:");
            foreach (var card in Hand)
            {
                card.DisplayCard();
                Console.WriteLine();
            }
        }

        // Selection (If/Else:): Check if the player still has cards left.
        public bool HasCards()
            {
                return Hand.Count > 0;
            }
        
    }
}