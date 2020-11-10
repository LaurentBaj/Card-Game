using System;
using System.Collections.Generic;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create deck + amount at game start
            Deck d1 = new Deck();

            //Create: players (based on input) + provide player hand + print results
            GameResponses.DisplayWelComeMessage();
            int numberOfPlayers = PlayerFactory.DecideAmountOfPLayers();
            PlayerFactory players = new PlayerFactory(numberOfPlayers);

            
            Board board = new Board(); // Create participants

            // Display card-switching
            Board.PlayerAction();


            Console.WriteLine("\n"); 


            // Show player hand + display different suits of hand 
            Console.WriteLine(Board.playersOnBoard[0].Name); 
            Board.playersOnBoard[0].ShowHand();
            Console.WriteLine("\n" + Board.playersOnBoard[0].Name + " - Suit types: ");
            Board.playersOnBoard[0].PlayerHandSuit();

            Console.ReadLine(); 
        }
    }
}
