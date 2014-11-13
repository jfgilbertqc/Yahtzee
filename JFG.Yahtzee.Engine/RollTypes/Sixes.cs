using JFG.Yahtzee.Engine.Algorithms;

namespace JFG.Yahtzee.Engine.RollTypes{
    public class Sixes : RollType{

        public Sixes() : base( new SimpleNumbersAlgorithm(6)){}
    }
}