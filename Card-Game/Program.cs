using System;
using System.Collections.Generic;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            Console.WriteLine(d1.deck.Count);

            int numberOfPlayers = 0;
            Console.WriteLine("Choose the amount of players (2-4)");
            while (numberOfPlayers > 4 || numberOfPlayers < 2)
            {
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                if (numberOfPlayers > 4 || numberOfPlayers < 2)
                {
                    Console.WriteLine("That is not a valid amount of players. Try again (2-4)");
                }
            }

            Console.WriteLine("");

            PlayerFactory a = new PlayerFactory(numberOfPlayers);
            for (int i = 0; i < numberOfPlayers; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    PlayerFactory.players[i]._hand[j] = d1.PullCardFromDeck(); 
                } 
            }

            Console.WriteLine(""); 

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(PlayerFactory.players[i].Name); 
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(PlayerFactory.players[i]._hand[j] + ", ");
                }
            }

            Console.WriteLine("\n");
            d1.PrintDeck();
            Console.WriteLine(d1.deck.Count);



            Console.ReadLine(); 
        }
       
    }
}
