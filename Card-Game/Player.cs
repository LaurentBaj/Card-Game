using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    public class Player
    {
        public string[] _hand = new string[4]; 
        public string[] _handSuits = new string[4];

        public bool hasWinnerHand = false; 

        public string Name { get; set; } 

        public Player(string name)
        {
            Name = name;
        }

        public void ShowHand()
        {
            foreach (string p in _hand)
            {
                Console.WriteLine(p); 
            }
        }

        public void isWinnerHand() // Check if Player has a winning hand
        {
            PlayerHandSuit(); 
            if (
                _handSuits[0] == "Spades" && _handSuits[1] == "Spades" && _handSuits[2] == "Spades" && _handSuits[3] == "Spades" ||
                _handSuits[0] == "Hearts" && _handSuits[1] == "Hearts" && _handSuits[2] == "Hearts" && _handSuits[3] == "Hearts" ||
                _handSuits[0] == "Diamonds" && _handSuits[1] == "Diamonds" && _handSuits[2] == "Diamonds" && _handSuits[3] == "Diamonds" ||
                _handSuits[0] == "Clubs" && _handSuits[1] == "Clubs" && _handSuits[2] == "Clubs" && _handSuits[3] == "Clubs"
               ) 
            { 
                Console.WriteLine("\n\n" + Name.ToUpper() + " IS THE WINNER!!");
                ShowHand();
                hasWinnerHand = true;
            }
           
        }

        public void PlayerHandSuit() // Fill suit-info of each card
        {
            for (int i = 0; i < 4; i++)
            {
                string[] splittedCard = _hand[i].Split(" ");
                _handSuits[i] = splittedCard[2];
            }
        }
        
    }
}
