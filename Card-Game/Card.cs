using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    class Card
    {
        private string card = ""; 

        public string[] suit = new string[] { "Clubs", "Diamonds", "Spade", "Hearts" };
        public int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Random s = new Random(); 
        Random n = new Random();

        public string createCard()
        {
            card = number[n.Next(1, 11)] + " of " + suit[s.Next(1, 4)];
            return card; 
        }
        
    }
}
