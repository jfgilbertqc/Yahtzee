using JFG.Yahtzee.Engine.Algorithms;

namespace JFG.Yahtzee.Engine.RollTypes
{
    public class LongStraight : RollType
    {
        public LongStraight(): base(new StraightAlgorithm(StraightAlgorithm.StraightType.Long)){}
    }
}
