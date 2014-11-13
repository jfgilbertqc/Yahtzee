using System.Collections.Generic;
using FluentAssertions;
using JFG.Yahtzee.Engine.GameElements;
using JFG.Yahtzee.Engine.RollTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JFG.Yahtzee.Engine.Tests
{
    [TestClass]
    public class OfKindTests
    {
        [TestMethod]
        public void ThreeKind_NotThreeNumbersEqual_ReturnZero()
        {
            var lst = createListWithNoEqual();
            var threeKind = new ThreeKind();
            threeKind.SetValue(lst);
            threeKind.Value.Should().Be(0);
        }

        [TestMethod]
        public void ThreeKind_ThreeNumbersEqual_ReturnsGoodNumber()
        {
            var lst = createListWithMultipleSixes(3);
            var threeKind = new ThreeKind();
            threeKind.SetValue(lst);
            threeKind.Value.Should().Be(20);
        }

        [TestMethod]
        public void FourKind_NotFourNumbersEqual_ReturnsZero()
        {
            var lst = createListWithNoEqual();
            var fourKind = new FourKind();
            fourKind.SetValue(lst);
            fourKind.Value.Should().Be(0);
        }

        [TestMethod]
        public void FourKind_FourNumbersEqual_ReturnsGoodNumber()
        {
            var lst = createListWithMultipleSixes(4);
            var fourKind = new FourKind();
            fourKind.SetValue(lst);
            fourKind.Value.Should().Be(25);
        }

        [TestMethod]
        public void FullHouse_WrongNumbers_ReturnZero()
        {
            var lst = createListWithNoEqual();
             var fullHouse = new FullHouse();
            fullHouse.SetValue(lst);
            fullHouse.Value.Should().Be(0);

        }

        [TestMethod]
        public void FullHouse_2SetsOfEqualNumbers_ReturnGoodNumber()
        {
            var lst = new List<Die>();
            lst.Add(new Die { Color = DieColor.Green, Value = 1 });
            lst.Add(new Die { Color = DieColor.Green, Value = 1 });
            lst.Add(new Die { Color = DieColor.Green, Value = 2 });
            lst.Add(new Die { Color = DieColor.Green, Value = 2 });
            lst.Add(new Die { Color = DieColor.Green, Value = 2 });
            var fullHouse = new FullHouse();
            fullHouse.SetValue(lst);
            fullHouse.Value.Should().Be(25);

        }

        public void FullHouse_Only2EqualNumbers_ReturnsZero()
        {
            var lst = new List<Die>();
            lst.Add(new Die { Color = DieColor.Green, Value = 1 });
            lst.Add(new Die { Color = DieColor.Green, Value = 1 });
            lst.Add(new Die { Color = DieColor.Green, Value = 2 });
            lst.Add(new Die { Color = DieColor.Green, Value = 3 });
            lst.Add(new Die { Color = DieColor.Green, Value = 4 });
            var fullHouse = new FullHouse();
            fullHouse.SetValue(lst);
            fullHouse.Value.Should().Be(0);

        }

        public void FullHouse_Only3EqualNumbers_ReturnsZero()
        {
            var lst = new List<Die>();
            lst.Add(new Die { Color = DieColor.Green, Value = 1 });
            lst.Add(new Die { Color = DieColor.Green, Value = 2 });
            lst.Add(new Die { Color = DieColor.Green, Value = 3 });
            lst.Add(new Die { Color = DieColor.Green, Value = 3 });
            lst.Add(new Die { Color = DieColor.Green, Value = 3 });
            var fullHouse = new FullHouse();
            fullHouse.SetValue(lst);
            fullHouse.Value.Should().Be(0);

        }

        private List<Die> createListWithNoEqual()
        {
            var Dice = new List<Die>();
            Dice.Add( new Die{ Color = DieColor.Green, Value=1 } );
            Dice.Add(new Die { Color = DieColor.Green, Value = 2 });
            Dice.Add(new Die { Color = DieColor.Green, Value = 3 });
            Dice.Add(new Die { Color = DieColor.Green, Value = 4 });
            Dice.Add(new Die { Color = DieColor.Green, Value = 5 });

            return Dice;
        }

        private List<Die> createListWithMultipleSixes(  int numberOfOccurences)
        {
            var Dice = new List<Die>();

            for (int i = 0; i < numberOfOccurences; i++)
            {
                Dice.Add(new Die{ Color = DieColor.Green, Value =  6 });
            }


            for (int i = 0; i < 5-numberOfOccurences; i++)
            {
                Dice.Add(new Die { Color = DieColor.Green, Value = 1 });
            }

            return Dice;
        }
    }
}
