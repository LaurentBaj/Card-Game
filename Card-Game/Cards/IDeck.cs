using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game
{
    public interface IDeck : ICards
    {
        void ProduceDeck();
        void ShuffleDeck();
    }
}
