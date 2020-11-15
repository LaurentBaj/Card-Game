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


            if (newCard == "2 of Clubs")
            {
                Console.WriteLine("\n" + randomPlayer.Name + " stepped on the bomb! (2 of Clubs) Throw your hand and recieve new cards\n");
                for (int i = 0; i < 4; i++)
                {
                    randomPlayer._hand[i] = Deck.PullCardFromDeck();
                }
                return; 
            } 
            else if (newCard == "10 of Diamonds")
            {
                Console.WriteLine("\n" + randomPlayer.Name + " caught the Vulture! (10 of Diamonds) Try again!\n");
                return; 
            }
            //else if (newCard == "King of Hearts")
            //{

            //}



            else
            {
                Deck.deck.Add(randomCardFromPlayer);
                randomPlayer._hand[cardToBeReplacedIndex] = newCard;

                // Display process above, check player victory + sleep 1.2s 
                Console.WriteLine(randomPlayer.Name + " swaps [" + randomCardFromPlayer + "] - with - " + "[" + newCard + "]");
                randomPlayer.isWinnerHand();  // Check if player has won 
            }
         
        }


       


    }
}
