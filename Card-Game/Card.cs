using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Game
{
    class Card
    {
        private string card;

        public string[] suit = new string[] { "Clubs", "Diamonds", "Spade", "Hearts" };
        public string[] cardValue = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jester", "Queen", "King"}; 

        Random s = new Random();
        Random n = new Random();

        List<string> deck = new List<string>();  
        

        public string createCard()
        {
            card = ""; 
            if(deck.Count == 52)
            {
                return card;  
            }
            else if (!deck.Contains(card))
            {
                card = cardValue[n.Next(1, 13)] + " of " + suit[s.Next(0, 4)];
                deck.Add(card);
            } else
            {
                createCard(); 
            }
            return card; 
        }




    }
}
