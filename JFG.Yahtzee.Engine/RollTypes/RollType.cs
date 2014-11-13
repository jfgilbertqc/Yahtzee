using System;
using System.Collections.Generic;
using JFG.Yahtzee.Engine.Algorithms;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.RollTypes{
    public abstract class RollType{

        private readonly ICalculationAlgorithm _algorithm;

        protected RollType(ICalculationAlgorithm algorithm){
            _algorithm = algorithm;
        }

        public virtual void SetValue(List<Die> Dice){
            if (Dice == null) throw new ArgumentNullException(Messages.DiceCannotBeNull);
            Value = _algorithm.Calculate(Dice);
        }

        public int Value { get; protected set; }
        public bool IsPicked { get; set; }
    }
}
