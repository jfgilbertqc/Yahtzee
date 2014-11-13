using System;
using System.Collections.Generic;
using FluentAssertions;
using JFG.Yahtzee.Engine.GameElements;
using JFG.Yahtzee.Engine.RollTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JFG.Yahtzee.Engine.Tests {
    [TestClass]
    public class YahtzeeTests {
      
        [TestMethod]
        public void FiveKind_NoFiveKind_ReturnsZero()
        {
            var fiveKind = new FiveKind();
            var Dice = new List<Die>
                          {
                              new Die {Value = 1},
                              new Die {Value = 2},
                              new Die {Value = 3},
                              new Die {Value = 4},
                              new Die {Value = 5}
                          };
          fiveKind.SetValue(Dice);
            fiveKind.Value.Should().Be(0);
        }


        [TestMethod]
        public void FiveKind_FiveKind_Returns50() {
            var fiveKind = new FiveKind();
            var Dice = new List<Die>
                          {
                              new Die {Value = 1},
                              new Die {Value = 1},
                              new Die {Value = 1},
                              new Die {Value = 1},
                              new Die {Value = 1}
                          };
            fiveKind.SetValue(Dice);
            fiveKind.Value.Should().Be(FiveKind.FiveKindValue);
        }
    }
}
