using System;
using System.Collections.Generic;
using JFG.Yahtzee.Engine.Algorithms;

namespace JFG.Yahtzee.Engine.RollTypes{
    public class ShortStraight : RollType{
        
        public ShortStraight(): base(new StraightAlgorithm(StraightAlgorithm.StraightType.Short)){}
    }
}
