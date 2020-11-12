using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Card_Game
{
    public class Board
    {
        public static Player[] playersOnBoard;

        public Board()
        {
            playersOnBoard = new Player[PlayerFactory.players.Length];
            FillBoardWithPlaters(); 
        }

        private void FillBoardWithPlaters()
        {
            for (int i = 0; i < playersOnBoard.Length; i++) 
            {
                playersOnBoard[i] = PlayerFactory.players[i];
            }
        }


        // Random player switches card
        // This method is supposed to have a lock 
        // A lot of Console.WriteLine()-methods for testing
        public static void PlayerAction() // Condition at the end does not work yet 
        {
            Random a = new Random();
            Random card = new Random();
            int randomCard = card.Next(0, 4); 

            Player randomPlayer = playersOnBoard[a.Next(0, playersOnBoard.Length)]; // pick random player
     
            string randomCardFromPlayer = randomPlayer._hand[randomCard]; // pick random card from same random player
            string newCard = Deck.PullCardFromDeck();
            
            Deck.deck.Add(randomCardFromPlayer);
            randomPlayer._hand[randomCard] = newCard;

            Console.WriteLine(randomPlayer.Name + " swaps [" + randomCardFromPlayer + "] with - " + "[" + newCard + "]"); 

            randomPlayer.isWinnerHand();  // Check if player has won

            Thread.Sleep(1500);
        }

    }
}
