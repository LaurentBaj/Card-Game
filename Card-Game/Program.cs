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

            //Create: players (based on input) + provide player hand + print results
            GameResponses.DisplayWelComeMessage();
            int numberOfPlayers = PlayerFactory.DecideAmountOfPLayers();
            PlayerFactory players = new PlayerFactory(numberOfPlayers);

            Board board = new Board(); // Create participants

            // Starts the game
            GameInitializer(numberOfPlayers);

        }

        private static void GameInitializer(int numberOfPlayers)
        {
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < 200; i++)
            {
                Thread t = new Thread(new ThreadStart(Board.PlayerAction));
                threads.Add(t);
            }

            for (int i = 0; i < 200; i++)
            {
                threads[i].Start();

                Thread.Sleep(100);

                for (int j = 0; j < numberOfPlayers; j++)
                {
                    if (Board.playersOnBoard[j].hasWinnerHand == true) End();
                }
            }
        }

        static void End()
        {
            Console.ReadKey(true);
        }
    }
}
