using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    public class PlayerFactory
    {
        public Player[] players; 
        public PlayerFactory(int amount, Player[] array)
        {
            array = new Player[amount];
            players = new Player[amount];


            for (int i = 0; i < amount; i++)
            {
                array[i] = new Player("Player " + (i + 1));
                players[i] = new Player("Player " + (i + 1)); 
            }
        }
    }
}
