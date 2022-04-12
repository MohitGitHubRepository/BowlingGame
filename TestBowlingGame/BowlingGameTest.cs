using BowlingApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace TestBowlingGame
{
    [TestClass]
    public class BowlingGameTest
    {

        BowlingGame game;

        [TestInitialize]
        public void InitializeBowlingGame()
        {
            game = new BowlingGame();
        }

        [TestMethod]
        public void AbleToRollGutterGame()
        {
            Rolls(20, 0);
            Assert.AreEqual(0, game.GetScore());
        }
        [TestMethod]
        public void AbleToRollOnes()
        {
            Rolls(20, 1);

            Assert.AreEqual(20, game.GetScore());
        }

        [TestMethod]
        public void AbleToRollSpare()
        {
            game.AddRollScore(5);
            game.AddRollScore(5);
            game.AddRollScore(1);
            Rolls(17, 0);
            Assert.AreEqual(12, game.GetScore());
        }

        [TestMethod]
        public void AbleToRollStrike()
        {
            game.AddRollScore(0);
            game.AddRollScore(10);
            game.AddRollScore(3);
            game.AddRollScore(3);
            Rolls(16, 0);
            Assert.AreEqual(19, game.GetScore());
        }
        [TestMethod]
        public void AbleToRollPerfectGame()
        {
            Rolls(12, 10);
            Assert.AreEqual(300, game.GetScore());
        }

        private void Rolls(int numberofchances, int pinsHits)
        {
            for (int i = 0; i < numberofchances; i++)
            {
                game.AddRollScore(pinsHits);
            }
        }
    }
}
