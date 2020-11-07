using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    public class Player
    {
        public Card[] _hand = new Card[4];  
        public string Name { get; set; } 

        public Player(string name)
        {
            Name = name;
            hand(); 
        }



        private string[] suit = new string[] { "Spades", "Hearts", "Diamonds", "Clubs" };
        private string[] value = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jester", "Queen", "King" };

        Random v = new Random();
        Random s = new Random();
        public Card produceCard()
        {
            Card c = new Card(value[v.Next(1, 12)], suit[s.Next(1, 4)]);
            return c;
        }



        public Card[] hand()
        {
            for (int i = 0; i < _hand.Length; i++)
            {
                _hand[i] = produceCard();  
            }

            return _hand; 
        }

        public void showHand()
        {
            for (int i = 0; i < _hand.Length; i++)
            {
                Console.WriteLine(this._hand[i].ToString()); 
            }
        }

    }
}
