using System;
using System.Collections.Generic;
using JFG.Yahtzee.Engine.Algorithms;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.RollTypes{
    public class FullHouse : RollType{
        
        private readonly OfAKindAlgorithm _twoAlgorithm = new OfAKindAlgorithm(2);
        private readonly OfAKindAlgorithm _threeAlgorithm = new OfAKindAlgorithm(3);

        public FullHouse() : base(null) { }

        public override void SetValue(List<Die> Dice){
            if (Dice == null) throw new ArgumentNullException(Messages.DiceCannotBeNull);
            var tempValue = _twoAlgorithm.Calculate(Dice);
            if (tempValue != 0)
            {
                tempValue = _threeAlgorithm.Calculate(Dice);
                Value = tempValue != 0 ? 25 : 0;
            }
            else
            {
                Value = 0;
            }
           
        }
       
    }
}