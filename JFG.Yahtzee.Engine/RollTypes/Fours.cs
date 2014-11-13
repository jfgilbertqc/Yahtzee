using JFG.Yahtzee.Engine.Algorithms;

namespace JFG.Yahtzee.Engine.RollTypes{
    public class Fours : RollType{

        public Fours(): base(new SimpleNumbersAlgorithm(4)){}

    }
}