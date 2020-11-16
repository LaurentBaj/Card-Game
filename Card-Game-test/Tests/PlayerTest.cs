using Card_Game;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game_test
{
    public class PlayerTest
    {

        [TestCase("Laurent", "Laurent")]
        [TestCase("Daniel", "Daniel")]
        public void Affirm_Player_Name(string name, string exptected)
        {
            Player a = new Player(name);
            Assert.IsTrue(a.Name == exptected);
        }

        [Test]
        public void Affirm_Winner_Hand()
        {
            Player a = new Player("Anastasia");
            Player b = new Player("Benjamin");

            a._hand[0] = "Ace of Spades";
            a._hand[1] = "2 of Spades";
            a._hand[2] = "King of Spades";
            a._hand[3] = "7 of Spades";

            b._hand[0] = "Ace of Hearts";
            b._hand[1] = "2 of Diamonds";
            b._hand[2] = "King of Clubs";
            b._hand[3] = "7 of Hearts";

            a.isWinnerHand();
            b.isWinnerHand();

            Assert.IsTrue(a.hasWinnerHand);
            Assert.IsFalse(b.hasWinnerHand);
        }

    }
}
