using JFG.Yahtzee.Engine.Algorithms;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.RollTypes {
    public class Greens : RollType {

        public Greens(): base(new ColorsAlgorithm(DieColor.Green, 5)){}
     
    }
}
