using System;
using System.Collections.Generic;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            Player[] players = null;
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


            PlayerFactory a = new PlayerFactory(numberOfPlayers, players);

            for (int i = 0; i < a.players.Length; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    a.players[i]._hand[j] = d1.PullCardFromDeck(); 
                } 
            }

            Console.WriteLine(""); 

            for (int i = 0; i < a.players.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(a.players[i].Name); 
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(a.players[i]._hand[j]);
                }
            }


            //Console.WriteLine("");

            //Deck d1 = new Deck();

            //Console.WriteLine("\n");

            //d1.PullCardFromDeck();

            //d1.PrintDeck();


            //d1.PullCardFromDeck();

            //d1.PrintDeck();



            Console.ReadLine(); 
        }
       
    }
}
