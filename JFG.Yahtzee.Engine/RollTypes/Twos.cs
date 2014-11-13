using JFG.Yahtzee.Engine.Algorithms;

namespace JFG.Yahtzee.Engine.RollTypes{
    public class Twos : RollType{
        public Twos(): base(new SimpleNumbersAlgorithm(2)){}
    }
}
