using System;
using System.Collections.Generic;
using JFG.Yahtzee.Engine.Algorithms;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.RollTypes {
    public class ColoredFullHouse : RollType{
        
        public const int ColoredFullHouseValue = 25;
        
        public ColoredFullHouse() : base(null){}
        
        public override void SetValue(List<Die> Dice) {
            if (Dice == null) throw new ArgumentNullException(Messages.DiceCannotBeNull);

            var twoFound = CheckIfTwoFound(Dice);

            var algorithm = new ColorsAlgorithm(DieColor.Green, 3);
            if (twoFound)
            {
                var threeFound = algorithm.Calculate(Dice) > 0;
                if (!threeFound) {
                    algorithm.Color = DieColor.Red;
                    threeFound = algorithm.Calculate(Dice) > 0;
                }

                if (!threeFound) {
                    algorithm.Color = DieColor.Yellow;
                    threeFound = algorithm.Calculate(Dice) > 0;
                }
                Value = threeFound ? ColoredFullHouseValue : 0;
 
            }
            else
            {
                Value = 0;
            }

        }

        private bool CheckIfTwoFound(List<Die> Dice){
            var algorithm = new ColorsAlgorithm(DieColor.Green, 2);
            bool twoFound = algorithm.Calculate(Dice) > 0;
            
            if (!twoFound) {
                algorithm.Color = DieColor.Red;
                twoFound = algorithm.Calculate(Dice) > 0;
            }

            if (!twoFound) {
                algorithm.Color = DieColor.Yellow;
                twoFound = algorithm.Calculate(Dice) > 0;
            }

            return twoFound;
        }

    }
}