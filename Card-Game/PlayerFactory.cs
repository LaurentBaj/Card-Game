using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    public class PlayerFactory
    {
        public PlayerFactory(int amount, Player[] array)
        {
            array = new Player[amount];

            for (int i = 0; i < amount; i++)
            {
                array[i] = new Player("Player " + (i + 1));
                Console.WriteLine(array[i].Name);
                array[i].showHand(); 
            }
        }
    }
}
