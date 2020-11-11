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

           
            // Confirm player victory 
            // Spotted some wierd anomalities 
            for (int i = 0; i < 1000; i++)
            {
                Board.PlayerAction(); 
            }



            Console.WriteLine("\n");
        }
    }
}
