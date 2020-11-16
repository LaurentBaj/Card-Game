using Card_Game;
using NUnit.Framework;

namespace Card_Game_test
{
    public class Tests
    {

        [TestCase(52, 0)]
        [TestCase(32, 20)]
        public void Affirm_Correct_Amount_Of_Cards_After_Withdraw(int cardsRemoved, int exptectedCards)
        {
            Deck a = new Deck();

            for (int i = 0; i < cardsRemoved; i++)
            {
                Deck.PullCardFromDeck();
            }

            Assert.IsTrue(Deck.deck.Count == exptectedCards);
        }


        



    }


}