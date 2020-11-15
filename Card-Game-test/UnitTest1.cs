using Card_Game;
using NUnit.Framework;

namespace Card_Game_test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Player a = new Player("Laurnet");
            Assert.IsTrue(a.Name == "Laurent"); 
        }
    }
}