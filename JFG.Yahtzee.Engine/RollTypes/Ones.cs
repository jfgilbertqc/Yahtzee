using JFG.Yahtzee.Engine.Algorithms;

namespace JFG.Yahtzee.Engine.RollTypes{
    public class Ones : RollType{
        public Ones(): base(new SimpleNumbersAlgorithm(1)){}
    }
}
