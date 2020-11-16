using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;

namespace Card_Game
{
    public class Deck 
    {
        static Object _lock = new Object();  // Lock
        public static List<string> deck = new List<string>(); // Empty deck-slots 
        Random r = new Random(); 

        // Suits and Values
        private string[] suit = new string[] { "Spades", "Hearts", "Diamonds", "Clubs" };
        private string[] value = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        public Deck() // Fill deck, shuffle it + Specials appear later 
        {
            ProduceDeck();
            ShuffleDeck();
            SetSpecialsAtCorrectIndex(); 
        }

        private void ProduceDeck() // Produce each card (non-shuffled)
        {
            string v, s;
            for (int i = 0; i < suit.Length; i++)
            {
                s = suit[i];

                for (int j = 0; j < value.Length; j++)
                {
                    v = value[j];
                    deck.Add(v + " of " + s);
                }
            }
        }

        private void ShuffleDeck()
        {
            int shuffleIndex;
            string temp = "";
            for (int i = 0; i < 52; i++)
            {
                for (int j = 0; j < 52; j++)
                {
                    shuffleIndex = r.Next(0, 52);

                    temp = deck[j];
                    deck[j] = deck[shuffleIndex];
                    deck[shuffleIndex] = temp;
                }
            }
        }

        public static void PrintDeck() // For testing
        {
            foreach (string d in deck)
            {
                Console.WriteLine(d.ToString());
            }
            Console.WriteLine("\n");
        }

        public static string PullCardFromDeck() // Pull one card from top
        {
            lock(_lock)
            {
                string temp = deck[0];
                deck.Remove(deck[0]);
                return temp;
            }
        }

        // Decreacse chance of Special Cards appear at the beginning of game (17-52 index)
        private void SetSpecialsAtCorrectIndex()
        {
            Random r = new Random();
            int replaceAtIndex = r.Next(17, 51);
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < deck.Count; j++)
                {
                    if (deck[j].ToString() == "King of Hearts" || deck[j].ToString() == "10 of Diamonds" || deck[j].ToString() == "2 of Clubs")
                    {
                        string temp = deck[j];
                        deck[j] = deck[replaceAtIndex];
                        deck[replaceAtIndex] = temp;
                    }
                }
            }   
        }


    }
}
