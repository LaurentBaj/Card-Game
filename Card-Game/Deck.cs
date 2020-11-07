using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;

namespace Card_Game
{
    class Deck
    {
        private string[] deck = new string[52]; // Empty deck-slots 

        // Suits and Values
        private string[] suit = new string[] {"Spades", "Hearts", "Diamonds", "Clubs"};  
        private string[] value = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jester", "Queen", "King"};
        
        public Deck()
        {
            produceDeck(); // Fill deck and print 
        }


        public void produceDeck() // Non-shuffled
        {
            string v, s;
            int counter = 0; 

           for (int i = 0; i < suit.Length; i++)
            {
                s = suit[i]; 

                for (int j = 0; j < value.Length; j++)
                {
                    v = value[j];
                    deck[counter] = v + " of " + s;
                    counter++;
                }
            }

            foreach (string d in deck)
            {
                Console.WriteLine(d.ToString());
            }
        }


    }
}
