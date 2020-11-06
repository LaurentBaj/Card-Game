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

        
        public void createDeck(List<string> list)
        {
            while (list.Count != 52 || !list.Contains(card))
            {
                card = cardValue[n.Next(1, 13)] + " of " + suit[s.Next(0, 4)];
                list.Add(card);
            }
        }

    }
}
