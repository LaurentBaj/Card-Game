using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    public class PlayerFactory
    {
        public static Player[] players; 
        public PlayerFactory(int amount)
        {
            players = new Player[amount];

            for (int i = 0; i < amount; i++)
            {
                players[i] = new Player("Player " + (i + 1)); 
            }
        }
    }
}
