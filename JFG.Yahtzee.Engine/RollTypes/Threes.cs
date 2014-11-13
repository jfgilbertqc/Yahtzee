using JFG.Yahtzee.Engine.Algorithms;

namespace JFG.Yahtzee.Engine.RollTypes{
    public class Threes : RollType{

        public Threes(): base(new SimpleNumbersAlgorithm(3)){}
      
    }
}