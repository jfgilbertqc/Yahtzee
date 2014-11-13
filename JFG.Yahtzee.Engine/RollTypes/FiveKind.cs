using System.Collections.Generic;
using JFG.Yahtzee.Engine.Algorithms;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.RollTypes {
    public class FiveKind : RollType{
       
        public const int FiveKindValue = 50;
        private readonly OfAKindAlgorithm _algorithm = new OfAKindAlgorithm(5);

        public FiveKind() : base(null){}

        public override void SetValue(List<Die> Dice){
            Value = _algorithm.Calculate(Dice) > 0 ? 50:0;
        }

    }
}
