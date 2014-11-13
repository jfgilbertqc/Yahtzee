using System;
using System.Text;
using System.Collections.Generic;
using FluentAssertions;
using JFG.Yahtzee.Engine.GameElements;
using JFG.Yahtzee.Engine.RollTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JFG.Yahtzee.Engine.Tests {
   
    [TestClass]
    public class ColorsTests {
       
   
        [TestMethod]
        public void Reds_NotallReds_ReturnsZero()
        {
            var reds = new Reds();
            var Dice = createMixedColors();
            reds.SetValue(Dice);
            reds.Value.Should().Be(0);

        }

        [TestMethod]
        public void Reds_AllReds_Returns40() {
            var reds = new Reds();
            var Dice = createColors(DieColor.Red);
            reds.SetValue(Dice);
            reds.Value.Should().Be(40);

        }

        [TestMethod]
        public void Greens_NotallGreens_ReturnsZero() {
            var greens = new Greens();
            var Dice = createMixedColors();
            greens.SetValue(Dice);
            greens.Value.Should().Be(0);

        }

        [TestMethod]
        public void Greens_AllGreens_Returns40() {
            var greens = new Greens();
            var Dice = createColors(DieColor.Green);
            greens.SetValue(Dice);
            greens.Value.Should().Be(40);

        }


        [TestMethod]
        public void Yellows_NotallYellows_ReturnsZero() {
            var yellows = new Yellows();
            var Dice = createMixedColors();
            yellows.SetValue(Dice);
            yellows.Value.Should().Be(0);

        }

        [TestMethod]
        public void Yellows_AllYellows_Returns40() {
            var yellows = new Yellows();
            var Dice = createColors(DieColor.Yellow);
            yellows.SetValue(Dice);
            yellows.Value.Should().Be(40);

        }

        [TestMethod]
        public void ColoredFullHouse_MixedColors_ReturnsZero() {
            var coloredFullHouse = new ColoredFullHouse();
            var Dice = createMixedColors();
            coloredFullHouse.SetValue(Dice);
            coloredFullHouse.Value.Should().Be(0);

        }

        [TestMethod]
        public void ColoredFullHouse_TwoYellowThreeGreen_Returns25() {
            var coloredFullHouse = new ColoredFullHouse();
            var Dice = createFullHouseColors(DieColor.Yellow, DieColor.Green);
            coloredFullHouse.SetValue(Dice);
            coloredFullHouse.Value.Should().Be(ColoredFullHouse.ColoredFullHouseValue);

        }

        [TestMethod]
        public void ColoredFullHouse_ThreeYellowTwoGreen_Returns25() {
            var coloredFullHouse = new ColoredFullHouse();
            var Dice = createFullHouseColors(DieColor.Green, DieColor.Yellow);
            coloredFullHouse.SetValue(Dice);
            coloredFullHouse.Value.Should().Be(ColoredFullHouse.ColoredFullHouseValue);

        }

        private List<Die> createFullHouseColors(DieColor twoColor, DieColor threeColor)
        {
            var Dice = new List<Die>();
            Dice.Add(new Die{ Color = twoColor });
            Dice.Add(new Die { Color = twoColor });
            Dice.Add(new Die { Color = threeColor });
            Dice.Add(new Die { Color = threeColor });
            Dice.Add(new Die { Color = threeColor });

            return Dice;
        }


        private List<Die> createColors(DieColor color)
        {
            var Dice = new List<Die>
                          {
                              new Die {Color = color},
                              new Die {Color = color},
                              new Die {Color = color},
                              new Die {Color = color},
                              new Die {Color = color}
                          };
            return Dice;
        }

        private List<Die> createMixedColors()
        {
            var Dice = new List<Die>
                          {
                              new Die {Color = DieColor.Green},
                              new Die {Color = DieColor.Green},
                              new Die {Color = DieColor.Green},
                              new Die {Color = DieColor.Red},
                              new Die {Color = DieColor.Yellow}
                          };
            return Dice;
        }
    }
}
