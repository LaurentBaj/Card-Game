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
            GameResponses.CountCards();

            //create: players (based on input) + provide player hand + print results
            GameResponses.DisplayWelComeMessage();
            int numberofplayers = PlayerFactory.DecideAmountOfPLayers(); 
            PlayerFactory players = new PlayerFactory(numberofplayers);

            Board board = new Board(); // join players 

            //starts the game
            GameInitializer(numberofplayers);
            GameResponses.CountCards();
        }

        private static void GameInitializer(int numberOfPlayers)
        {
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < 300; i++)
            {
                Thread t = new Thread(new ThreadStart(Board.PlayerAction));
                threads.Add(t);
            }

            for (int i = 0; i < 300; i++)
            {
                threads[i].Start();
                Thread.Sleep(250);

                for (int j = 0; j < numberOfPlayers; j++)
                {
                    if (Board.playersOnBoard[j].hasWinnerHand == true)
                    {
                        PlayerFactory.PrintEachPlayerAndHand(numberOfPlayers);
                        GameResponses.DisplayEachHandUponGameOver();
                        End();
                    }
                }
            }
        }

        static void End()
        {
            Console.WriteLine("\n\n..Hit the x on the right corner to quit"); 
            Console.ReadKey(true);
        }

    }
}
