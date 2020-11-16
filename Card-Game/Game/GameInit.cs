using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Card_Game
{
    public class GameInit
    {
        private bool isFinished; 
        public GameInit(int numberOfPlayers)
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
                        isFinished = true; 
                        End();
                    }
                }
                if (isFinished == true) break; 
            }
        }

        static void End()
        {
            Console.WriteLine("Press any button to quit the game: ");
            Console.ReadLine();
        }

        
    }
}
