using System;
using JFG.Yahtzee.Engine.GameElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JFG.Yahtzee.Engine.Tests {
    [TestClass]
    public class DiceBoardTests {
       
        [TestMethod]
        public void DiceBoard_Roll5_Returns5Newrolls()
        {
            var diceBoard = new DiceBoard();
            diceBoard.Roll();
        }
    }
}
