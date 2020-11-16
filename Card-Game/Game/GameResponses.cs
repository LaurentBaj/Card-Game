using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    public class GameResponses
    {
        public static void DisplayWelComeMessage()
        {
            Console.WriteLine("WELCOME TO THE CRAZY CARD GAME!");
            Console.WriteLine("\r\nChoose the amount of players (2-4)");
        }

        public static void DisplayAmountError()
        {
            Console.WriteLine("That is not a valid amount of players. Try again (2-4)\n");
        }

        public static void CountCards() // Mainly for testing 
        {
            Console.WriteLine("\n(Card count: " + Deck.deck.Count + ")\n"); 
        }

    }
}
