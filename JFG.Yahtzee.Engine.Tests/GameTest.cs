using System;
using JFG.Yahtzee.Engine.GameElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;


namespace JFG.Yahtzee.Engine.Tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void CreateGame_WithNumberOfPlayers_CreatesGame()
        {
            var game = new Game(2);

            game.Players.Should().HaveCount(2);

        }

        [TestMethod]
        public void CreateGame_WithNumberOfPlayers_CreatePlayersWithRightName()
        {
            var game = new Game(2);
            game.Players[0].Name.Should().Be("Player1");
            game.Players[1].Name.Should().Be("Player2");

        }

        [TestMethod]
        public void CreateGame_With2Players_Create2Boards() {
            var game = new Game(2);
            game.Boards.Count.Should().Be(2);
            game.Boards[0].Player.Name.Should().Be("Player1");
            game.Boards[1].Player.Name.Should().Be("Player2");

        }

        [TestMethod]
        public void CreateGame_WithTooFewPlayers_ShouldThrowArgumentOutOfRangeException()
        {
            Action act = () => new Game(0);
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void CreateGame_WithTooManyPlayers_ShouldThrowArgumentOutOfRangeException()
        {
            Action act = () => new Game(5);
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }
    }
}
