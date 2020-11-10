using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    public class Player
    {
        public string[] _hand = new string[4];  
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

        public void PlayerHandSuit()
        { 
            foreach (string p in _hand)
            {
                string[] a = p.Split(" ");
                Console.WriteLine(a[2]);
            }
        }
    }
}
