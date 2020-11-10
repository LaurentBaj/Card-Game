using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    public class Board
    {
        public static Player[] playersOnBoard;
        static Random a = new Random(); 

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
        public static void PlayerAction() 
        {
            Player randomPlayer = playersOnBoard[a.Next(0, playersOnBoard.Length - 1)];
            Console.WriteLine(randomPlayer.Name); 
            string randomCardFromPlayer = randomPlayer._hand[a.Next(0, 3)];
            string newCard = Deck.PullCardFromDeck();
            Deck.deck.Add(randomCardFromPlayer);
            randomPlayer._hand[a.Next(0, 3)] = newCard;
            randomPlayer.ShowHand(); 
        }



    }
}
