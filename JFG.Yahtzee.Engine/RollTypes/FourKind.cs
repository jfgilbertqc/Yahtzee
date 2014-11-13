using JFG.Yahtzee.Engine.Algorithms;

namespace JFG.Yahtzee.Engine.RollTypes{
    public class FourKind : RollType{

        public FourKind(): base(new OfAKindAlgorithm(4)){}

    }
}

