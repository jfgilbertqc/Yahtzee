using JFG.Yahtzee.Engine.Algorithms;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.RollTypes {
    public class Reds  : RollType {

        public Reds(): base(new ColorsAlgorithm(DieColor.Red, 5)){}
      
    }
}
