using System;
using System.Collections.Generic;
using FluentAssertions;
using JFG.Yahtzee.Engine.GameElements;
using JFG.Yahtzee.Engine.RollTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JFG.Yahtzee.Engine.Tests
{
    [TestClass]
    public class StraightsTests
    {
        [TestMethod]
        public void ShortStraight_NoStraight_ReturnsZero()
        {
            var straight = new ShortStraight();
            var lst = createNoStraightList();
            straight.SetValue(lst);
            straight.Value.Should().Be(0);

        }

        [TestMethod]
        public void ShortStraight_LeftAlignedStraight_ReturnsGoodNumber()
        {
            var straight = new ShortStraight();
            var lst = new List<Die>();
            lst.Add(new Die { Value = 1 });
            lst.Add(new Die { Value = 4 });
            lst.Add(new Die { Value = 3 });
            lst.Add(new Die { Value = 2 });
            lst.Add(new Die { Value = 1 });
            
            straight.SetValue(lst);
            straight.Value.Should().Be(30);

        }

        [TestMethod]
        public void ShortStraight_MiddleAlignedStraight_ReturnsGoodNumber()
        {
            var straight = new ShortStraight();
            var lst = new List<Die>();
            lst.Add(new Die { Value = 2 });
            lst.Add(new Die { Value = 3 });
            lst.Add(new Die { Value = 5 });
            lst.Add(new Die { Value = 2 });
            lst.Add(new Die { Value = 4 });

            straight.SetValue(lst);
            straight.Value.Should().Be(30);

        }

        [TestMethod]
        public void ShortStraight_RightAlignedStraight_ReturnsGoodNumber()
        {
            var straight = new ShortStraight();
            var lst = new List<Die>();
            lst.Add(new Die { Value = 6 });
            lst.Add(new Die { Value = 3 });
            lst.Add(new Die { Value = 5 });
            lst.Add(new Die { Value = 2 });
            lst.Add(new Die { Value = 4 });

            straight.SetValue(lst);
            straight.Value.Should().Be(30);

        }

        [TestMethod]
        public void LongStraight_NoStraight_ReturnsZero()
        {
            var straight = new LongStraight();
            var lst = createNoStraightList();
          
            straight.SetValue(lst);
            straight.Value.Should().Be(0);

        }

        [TestMethod]
        public void LongStraight_LeftAlignedStraight_ReturnsGoodNumber()
        {
            var straight = new LongStraight();
            var lst = new List<Die>
                          {
                              new Die {Value = 1},
                              new Die {Value = 5},
                              new Die {Value = 3},
                              new Die {Value = 2},
                              new Die {Value = 4}
                          };

            straight.SetValue(lst);
            straight.Value.Should().Be(40);

        }


        [TestMethod]
        public void LongStraight_RightAlignedStraight_ReturnsGoodNumber()
        {
            var straight = new LongStraight();
            var lst = new List<Die>
                          {
                              new Die {Value = 6},
                              new Die {Value = 5},
                              new Die {Value = 3},
                              new Die {Value = 2},
                              new Die {Value = 4}
                          };

            straight.SetValue(lst);
            straight.Value.Should().Be(40);

        }
        

        private List<Die> createNoStraightList()
        {
            var Dice = new List<Die>
                          {
                              new Die {Color = DieColor.Green, Value = 2},
                              new Die {Color = DieColor.Green, Value = 2},
                              new Die {Color = DieColor.Green, Value = 2},
                              new Die {Color = DieColor.Green, Value = 2},
                              new Die {Color = DieColor.Green, Value = 2}
                          };

            return Dice;
        }
    }
}
