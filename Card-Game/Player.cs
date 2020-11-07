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
        
        public Card[] hand()
        {
            for (int i = 0; i < _hand.Length; i++)
            {
                _hand[i] = new Card("Ace", "Spades"); 
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
