using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;

namespace Card_Game
{
    class Deck
    {
        private Card[] deck;

        private string[] suit = new string[] {"Spades", "Hearts", "Diamonds", "Clubs"};  
        private string[] value = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jester", "Queen", "King"};

        Random v = new Random(); 
        Random s = new Random();

        public Deck()
        {
            deck = new Card[52];

            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = produceCard();
                Console.WriteLine(deck[i].ToString());
            }
        }

        public Card produceCard()
        {
            Card c = new Card(value[v.Next(1, 12)], suit[s.Next(1, 4)]);
            return c; 
        }
    }
}
