using System;
using System.Collections.Generic;
using System.Threading;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create deck + amount at game start
            Deck d1 = new Deck();

            // Create players (based on input) + provide player hand + print results
            GameResponses.DisplayWelComeMessage();
            int numberofplayers = PlayerFactory.DecideAmountOfPLayers();
            PlayerFactory players = new PlayerFactory(numberofplayers);

            // Join players 
            Board board = new Board(); 

            // Start the game
            GameInit game = new GameInit(numberofplayers); 
        }
    }
}
