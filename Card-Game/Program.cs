using System;
using System.Collections.Generic;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck(); // Create deck

            // Amount of cards before game starts
            Console.WriteLine("(Card count: " + d1.deck.Count + ")\n"); 

            // Choose amount of players
            int numberOfPlayers = 0;
            Console.WriteLine("WELCOME TO THE CRAZY CARD GAME!");
            Console.WriteLine("\r\nChoose the amount of players (2-4)\n");
            while (numberOfPlayers > 4 || numberOfPlayers < 2)
            {
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                if (numberOfPlayers > 4 || numberOfPlayers < 2)
                {
                    Console.WriteLine("That is not a valid amount of players. Try again (2-4)");
                }
            }

            Console.WriteLine("");


            // Create players based on user-input 
            // Give them each a full hand
            PlayerFactory a = new PlayerFactory(numberOfPlayers);
            for (int i = 0; i < numberOfPlayers; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    PlayerFactory.players[i]._hand[j] = d1.PullCardFromDeck(); 
                } 
            }

            Console.WriteLine(""); 

            // Print each player and their cards
            // For testing
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("\n" + PlayerFactory.players[i].Name);
                Console.Write("[");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(PlayerFactory.players[i]._hand[j] + ", ");
                }
                Console.Write("\b\b]\n");
            }

            Console.WriteLine("\n");

            //Deck count after first delegation
            Console.WriteLine("\n(Card count after every player receives a hand: " +  d1.deck.Count + ")"); 



            Console.ReadLine(); 
        }
       
    }
}
