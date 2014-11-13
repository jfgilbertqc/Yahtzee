using JFG.Yahtzee.Engine.Algorithms;

namespace JFG.Yahtzee.Engine.RollTypes{
    public class Fives : RollType{

        public Fives(): base(new SimpleNumbersAlgorithm(5)){}

    }
}