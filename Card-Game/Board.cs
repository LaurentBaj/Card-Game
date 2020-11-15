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
        public static void PlayerAction() // Condition at the end does not work yet 
        {
            Random a = new Random();
            Random card = new Random();
            int cardToBeReplacedIndex = card.Next(0, 4); 

            // Pick random player + swap card from hand and deck
            Player randomPlayer = playersOnBoard[a.Next(0, playersOnBoard.Length)]; 
            string randomCardFromPlayer = randomPlayer._hand[cardToBeReplacedIndex]; 
            string newCard = Deck.PullCardFromDeck();
            Deck.deck.Add(randomCardFromPlayer);
            randomPlayer._hand[cardToBeReplacedIndex] = newCard;

            // Display process above, check player victory + sleep 1.2s 
            Console.WriteLine(randomPlayer.Name + " swaps [" + randomCardFromPlayer + "] - with - " + "[" + newCard + "]");
            randomPlayer.isWinnerHand();  // Check if player has won 
        }


        public void ValidateSpecialCards(string specialCard, Player randomPlayer)
        {
            if(specialCard == "2 of Clubs")
            {

            }
        }

    }
}
