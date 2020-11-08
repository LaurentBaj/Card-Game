using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;

namespace Card_Game
{
    class Deck
    {
        public static string[] deck = new string[52]; // Empty deck-slots 
        Random r = new Random();

        // Suits and Values
        private string[] suit = new string[] {"Spades", "Hearts", "Diamonds", "Clubs"};  
        private string[] value = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};


        public Deck() // Fill deck and shuffle it
        {
            ProduceDeck();
            ShuffleDeck();
        }

        public void ProduceDeck()
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
        }

        public void ShuffleDeck()
        {
            int shuffleIndex;
            string temp = ""; 
            
            for (int i = 0; i < 52; i++)
            {
                for (int j = 0; j < 52; j++)
                {
                    shuffleIndex = r.Next(1, 52);

                    temp = deck[j];
                    deck[j] = deck[shuffleIndex];
                    deck[shuffleIndex] = temp;
                }
            }
        }

        public void PrintDeck() // For testing
        {
            foreach (string d in deck)
            {
                Console.WriteLine(d.ToString());
            }
        }

        public string PullCardFromDeck()
        {
            int removeAtIndex = r.Next(1, 52); 
            string temp = deck[removeAtIndex];
            if (temp != "No card here")
            {
                deck[removeAtIndex] = "No card here";
                return temp;
            }
            PullCardFromDeck();
            return "No card here"; 
        }



    }
}
