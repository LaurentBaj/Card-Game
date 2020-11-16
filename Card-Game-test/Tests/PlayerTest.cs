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

            a.Hand[0] = "Ace of Spades";
            a.Hand[1] = "2 of Spades";
            a.Hand[2] = "King of Spades";
            a.Hand[3] = "7 of Spades";

            b.Hand[0] = "Ace of Hearts";
            b.Hand[1] = "2 of Diamonds";
            b.Hand[2] = "King of Clubs";
            b.Hand[3] = "7 of Hearts";

            a.isWinnerHand();
            b.isWinnerHand();

            Assert.IsTrue(a.hasWinnerHand);
            Assert.IsFalse(b.hasWinnerHand);
        }

    }
}
