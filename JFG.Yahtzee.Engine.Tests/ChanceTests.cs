using System;
using System.Collections.Generic;
using FluentAssertions;
using JFG.Yahtzee.Engine.GameElements;
using JFG.Yahtzee.Engine.RollTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JFG.Yahtzee.Engine.Tests
{
    [TestClass]
    public class ChanceTests
    {
        [TestMethod]
        public void Chance_Sum_EqualsToSumOfDice()
        {
            var chance = new Chance();
            var Dice = new List<Die>();
            Dice.Add(new Die{ Value = 1});
            Dice.Add(new Die { Value = 1 });
            Dice.Add(new Die { Value = 1 });
            Dice.Add(new Die { Value = 1 });
            Dice.Add(new Die { Value = 1 });

            chance.SetValue(Dice);
            chance.Value.Should().Be(5);
        }
    }
}
