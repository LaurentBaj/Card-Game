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

           
            // Initialize game - This is supposed to be threads (will implement it later)
            for (int i = 0; i < 200; i++)
            {
                Board.PlayerAction(); 
            }

            Console.WriteLine("\n");
        }
    }
}
