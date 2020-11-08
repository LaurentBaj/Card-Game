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
    }
}
