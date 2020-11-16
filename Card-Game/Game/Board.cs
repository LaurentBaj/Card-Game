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
            int chosenPlayer = a.Next(0, playersOnBoard.Length);

            // Pick random player + swap card from hand and deck
            Player randomPlayer = playersOnBoard[chosenPlayer];
            string randomCardFromPlayer = randomPlayer._hand[cardToBeReplacedIndex];
            string newCard = Deck.PullCardFromDeck();

            ProcessSpecialCards(a, cardToBeReplacedIndex, randomPlayer, randomCardFromPlayer, newCard);
        }


        // Check for specials and process them accordingly
        private static void ProcessSpecialCards(Random a, int cardToBeReplacedIndex, Player randomPlayer, string randomCardFromPlayer, string newCard)
        {
            if (newCard == "2 of Clubs") // If Bomb
            {
                Console.WriteLine("\n" + randomPlayer.Name + " stepped on the bomb! (2 of Clubs) Throw your hand and recieve new cards!\n");
                for (int i = 0; i < 4; i++)
                {
                    randomPlayer._hand[i] = Deck.PullCardFromDeck(); // Override current hand
                }
                return;
            }
            else if (newCard == "10 of Diamonds") // If Quarantine 
            {
                Console.WriteLine("\n" + randomPlayer.Name + " is under quarantine! (10 of Diamonds) Try again!\n");
                return;
            }
            else if (newCard == "King of Hearts") // SwapperMadness
            {
                Console.WriteLine("\n" + randomPlayer.Name
                    + " caught SwapperMadness! Swap one card from a random player!");
                Player randomPlayer2 = playersOnBoard[a.Next(0, playersOnBoard.Length)];

                while (randomPlayer2.Name == randomPlayer.Name) // Avert card-duplication
                {
                    randomPlayer2 = playersOnBoard[a.Next(0, playersOnBoard.Length)];
                }

                string randomCardFromPlayer2 = randomPlayer2._hand[cardToBeReplacedIndex];
                string tempCard = randomPlayer._hand[cardToBeReplacedIndex];
                randomPlayer._hand[cardToBeReplacedIndex] = randomCardFromPlayer2;
                randomPlayer2._hand[cardToBeReplacedIndex] = randomCardFromPlayer;
                Console.WriteLine(randomPlayer.Name + " swapped [" + randomCardFromPlayer + "] - with - [" + randomCardFromPlayer2 + "] from " + randomPlayer2.Name);
                Console.WriteLine("");
                return;
            }
            else // If not spec-card, swap normally
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
