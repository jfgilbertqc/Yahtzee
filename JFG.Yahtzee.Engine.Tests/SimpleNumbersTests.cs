using System.Collections.Generic;
using JFG.Yahtzee.Engine.GameElements;
using JFG.Yahtzee.Engine.RollTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace JFG.Yahtzee.Engine.Tests
{
    [TestClass]
    public class SimpleNumbersTests
    {
        [TestMethod]
        public void Ones_SetValue_GivesGoodNumber()
        {
            var ones = new Ones();
            var lst = createList(1);
            ones.SetValue(lst);
            ones.Value.Should().Be(2);
        }

        [TestMethod]
        public void Twos_SetValue_GivesGoodNumber()
        {
            var twos = new Twos();
            var lst = createList(2);
            twos.SetValue(lst);
            twos.Value.Should().Be(4);
        }

        [TestMethod]
        public void Threes_SetValue_GivesGoodNumber()
        {
            var threes = new Threes();
            var lst = createList(3);
            threes.SetValue(lst);
            threes.Value.Should().Be(6);
        }

        [TestMethod]
        public void Fours_SetValue_GivesGoodNumber()
        {
            var fours = new Fours();
            var lst = createList(4);
            fours.SetValue(lst);
            fours.Value.Should().Be(8);
        }

        [TestMethod]
        public void Fives_SetValue_GivesGoodNumber()
        {
            var fives = new Fives();
            var lst = createList(5);
            fives.SetValue(lst);
            fives.Value.Should().Be(10);
        }

        [TestMethod]
        public void Sixes_SetValue_GivesGoodNumber()
        {
            var sixes = new Sixes();
            var lst = createList(6);
            sixes.SetValue(lst);
            sixes.Value.Should().Be(12);
        }

        private List<Die> createList( int numberToInclude )
        {
            var Dice = new List<Die>();
            Dice.Add(new Die { Color = DieColor.Green, Value = numberToInclude});
            Dice.Add(new Die { Color = DieColor.Green, Value = numberToInclude });

            var otherNumber = numberToInclude == 6 ? 5 : numberToInclude+1;

            Dice.Add(new Die { Color = DieColor.Green, Value = otherNumber });
            Dice.Add(new Die { Color = DieColor.Green, Value = otherNumber });
            Dice.Add(new Die { Color = DieColor.Green, Value = otherNumber });

            return Dice;
        }
    }
}
