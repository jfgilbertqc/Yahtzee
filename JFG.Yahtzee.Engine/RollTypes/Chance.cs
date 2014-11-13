using System;
using System.Collections.Generic;
using System.Linq;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.RollTypes{
    public class Chance : RollType{

        public Chance() : base(null){}

        public override void SetValue(List<Die> Dice){
            if (Dice == null) throw new ArgumentNullException(Messages.DiceCannotBeNull);
            Value = (from val in Dice select val.Value).Sum();
        }
        
    }
}
