using JFG.Yahtzee.Engine.Algorithms;

namespace JFG.Yahtzee.Engine.RollTypes{
    public class ThreeKind : RollType{

        public ThreeKind(): base(new OfAKindAlgorithm(3)){}
    }
}

