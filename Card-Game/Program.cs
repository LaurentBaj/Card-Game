using System;
using System.Collections.Generic;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many players");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());

            Card c1 = new Card();
            List<Player> players = new List<Player>();

            AddMemberAndPrint(numberOfPlayers, c1, players);
        }

        private static void AddMemberAndPrint(int numberOfPlayers, Card c1, List<Player> players)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player("Player " + (i + 1)));
                Console.WriteLine(players[i].Name + " picks " + c1.createCard());
            }
        }
    }
}
