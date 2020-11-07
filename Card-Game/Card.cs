using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Game
{
    public class Card : ICard
    {
        private string _suit;
        private string _value;
        
        public Card(string value, string suit)
        {
            _suit = suit;
            _value = value; 
        }

        public string getSuit()
        {
            return _suit;
        }

        public string getValue()
        {
            return _value;
        }

        public override string ToString()
        {
            return _value + " of " + _suit;
        }
    }
}
