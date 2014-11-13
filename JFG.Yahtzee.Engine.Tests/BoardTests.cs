using System;
using JFG.Yahtzee.Engine.GameElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JFG.Yahtzee.Engine.Tests {
    [TestClass]
    public class BoardTests {
       
        [TestMethod]
        public void CreateBoard_AllRollTypesShouldBeNull()
        {
            var board = new GameBoard();
            Assert.IsNull(board.Ones);
            Assert.IsNull(board.Twos);
            Assert.IsNull(board.Threes);
            Assert.IsNull(board.Fours);
            Assert.IsNull(board.Fives);
            Assert.IsNull(board.Sixes);
            Assert.IsNull(board.ThreeKind);
            Assert.IsNull(board.FourKind);
            Assert.IsNull(board.FullHouse);
            Assert.IsNull(board.ShortStraight);
            Assert.IsNull(board.LongStraight);
            Assert.IsNull(board.Chance);
            Assert.IsNull(board.Reds);
            Assert.IsNull(board.Greens);
            Assert.IsNull(board.Yellows);
            Assert.IsNull(board.ColoredFullHouse);
            Assert.IsNull(board.FiveKind);
        }

      
    }

   
}
