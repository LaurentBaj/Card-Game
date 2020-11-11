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


            Random random = new Random();
            int randomNum = random.Next(0, numberOfPlayers - 1); 
            Console.WriteLine(Board.playersOnBoard[randomNum].Name);

            Board.playersOnBoard[randomNum].PlayerHandSuit();

            PlayerFactory.PrintEachPlayerAndHand(numberOfPlayers); 

            Console.ReadLine(); 
        }
    }
}
