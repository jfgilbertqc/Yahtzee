using JFG.Yahtzee.Engine.Algorithms;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.RollTypes {
    public class Yellows : RollType {

        public Yellows() : base( new ColorsAlgorithm(DieColor.Yellow,5)){}
       
    }
}