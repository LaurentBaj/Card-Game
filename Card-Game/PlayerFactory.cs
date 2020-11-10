using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    public class PlayerFactory
    {
        public static Player[] players; 
        public PlayerFactory(int amount) // Create players and give hand
        {
            players = new Player[amount];

            for (int i = 0; i < amount; i++)
            {
                players[i] = new Player("Player " + (i + 1)); 
            }

            ProduceEachPlayerHand(amount);
            PrintEachPlayerAndHand(amount);

            Console.WriteLine("");
        }

        public static int DecideAmountOfPLayers()
        {
            int numberOfPlayers = 0;
            while (numberOfPlayers > 4 || numberOfPlayers < 2)
            {
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                if (numberOfPlayers > 4 || numberOfPlayers < 2)
                {
                    GameResponses.DisplayAmountError(); 
                }
            }
            return numberOfPlayers; 
        }

        public static void ProduceEachPlayerHand(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PlayerFactory.players[i]._hand[j] = Deck.PullCardFromDeck();
                }
            }
        }

        public static void PrintEachPlayerAndHand(int amount) // For testing
        {
            Console.WriteLine("\n");
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("\n" + PlayerFactory.players[i].Name);
                Console.Write("[");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(PlayerFactory.players[i]._hand[j] + ", ");
                }
                Console.Write("\b\b]\n\n");
            }

            Console.WriteLine("\n");
        }


    }
}
