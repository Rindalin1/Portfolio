using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TopTrumps
{
 // The game class manages the overall game flow.
 public class Game
 {
    private List<Card> deck; //Data structures: List repesenting the deck of cards
    private Player player1; //Player 1
    private Player player2; // Player 2

    // Constructor to initalize the game with two players and a deck of cards
    public Game(Player p1, Player p2)
    {
        player1 = p1;
        player2 = p2;
        deck = new List<Card>();

        // Alrgorithms and Data Structures: Initialize the deck with sample cards.
        InitializeDeck();
        ShuffleDeck();
        DistributeCards();
    }

    // Algorithms: Initialize the deck with cards
    private void InitializeDeck()
    {
        // Add cards to the deck. These could be based on the selected theme.
        // Would like the cards "Dandelion, Emhry Var Emries and Radovid" do special moves will implement later
        deck.Add(new Card("Geralt", 80, 80, 80, 80));
        deck.Add(new Card("Yennefer", 10, 30, 30, 90));
        deck.Add(new Card("Triss", 20, 25, 20, 85));
        deck.Add(new Card("Vesemir", 60, 75, 65, 75));
        deck.Add(new Card("Letho", 90, 70, 85, 20));
        deck.Add(new Card("Radovid", 35, 35, 35, 35));
        deck.Add(new Card("Crones", 40, 60, 70, 80));
        deck.Add(new Card("Dandelion", 10, 10, 10, 10));
        deck.Add(new Card("Eredin Breac Glass", 95, 95, 70, 60));
        deck.Add(new Card("Ciri", 45, 100, 50, 100));
        deck.Add(new Card("Drowned Dead", 5, 40, 50, 0));
        deck.Add(new Card("Fiend", 58, 68, 78, 38));
        deck.Add(new Card("Higher Vampire", 64, 85, 100, 66));
        deck.Add(new Card("Wraith", 66, 66, 66, 66));
        deck.Add(new Card("Endega Worker", 42, 84, 23, 0));
        deck.Add(new Card("Emhyr Var Emries", 10, 10, 10, 10));
    }
    
    //Algorithms: Shuffle the deck of cards.
    private void ShuffleDeck()
    {
        Random rng = new Random();
        int n = deck.Count;
        while (n >1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card value = deck[k];
            deck[k] = deck[n];
            deck[n] = value;
        }
    }
    
    //Procedures: DistributeCards between the two players.
    private void DistributeCards()
    {
        for(int i = 0; i < deck.Count; i++)
        {
            if (i % 2 == 0)
                player1.AddCard(deck[i]);
                else
                player2.AddCard(deck[i]);
        }

    }

    // Procedures: Start the game.
    public void StartGame()
    {
        Console.WriteLine("Starting the Top Trumps Game!");

        // Iteration: Loop until one player has no cards left.
        while (player1.HasCards() && player2.HasCards())
        {
            PlayRound();
        }

        // Selecction (If/Else): Determine the winner based on who has the most cards
        DetermineWinner();
    }

    // Procedures handle one round of play
    private void PlayRound()
    {
        Console.WriteLine($"{player1.Name}, select an attribute to compare: Strength, Vitality, Defense, Magic");
        string attribute = Console.ReadLine();

        Card p1Card = player1.PlayCard();
        Card p2Card = player2.PlayCard();

        Console.WriteLine($"{player1.Name} played:");
        p1Card.DisplayCard();
        Console.WriteLine($"{player2.Name} played:");
        p2Card.DisplayCard();

        int result = Card.Compare(p1Card, p2Card, attribute);

        // Selection(If/Else): Determine the winner of the round.
        if (result > 0)
        {
            Console.WriteLine($"{player1.Name} wins this round!");
            player1.AddCard(p1Card);
            player1.AddCard(p2Card);
        }
        else if (result < 0)
        {
            Console.WriteLine($"{player2.Name} wins this round!");
            player2.AddCard(p1Card);
            player2.AddCard(p2Card);

        }
        else
        {
            Console.WriteLine("It's a tie! No cards are exchanged.");
            player1.AddCard(p1Card);
            player2.AddCard(p2Card);
        }
    }

    // Procedures: Determine and display the overall winner
    private void DetermineWinner()
    {
        if(player1.Hand.Count > player2.Hand.Count)
           Console.WriteLine($"{player1.Name} wins the game!");
           else if (player1.Hand.Count < player2.Hand.Count)
                   Console.WriteLine($"{player2.Name} wins the game!");
           else
               Console.WriteLine("The game is a tie!");        
    }
 }
}