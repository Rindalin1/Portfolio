using System;

namespace TopTrumps
{
class Program
{
    static void Main(string[]args)
    {

    
    //Input/Output: Welcoming the player to the game.

    Console.WriteLine("Welcome to the Top Trumps Game!");
    
    // Variables: Create two players.

    Player player1 = new Player("Player 1");
    Player player2 = new Player("Player 2");

    // Variables: Initialize the game with these two players

    Game game = new Game(player1, player2);

    // Procedures: Start the game.
    game.StartGame();
}
}
}
