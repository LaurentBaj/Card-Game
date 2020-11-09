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
            GameResponses.CountCards(); 

            GameResponses.DisplayWelComeMessage(); 

            //Create: players (based on input) + provide player hand + print results
            int numberOfPlayers = PlayerFactory.DecideAmountOfPLayers();
            PlayerFactory a = new PlayerFactory(numberOfPlayers);

            //Deck count after first delegation
            GameResponses.CountCards();

            Console.ReadLine(); 
        }
    }
}
