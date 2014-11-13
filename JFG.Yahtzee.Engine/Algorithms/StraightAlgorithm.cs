using System;
using System.Collections.Generic;
using System.Linq;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.Algorithms{
    public class StraightAlgorithm : ICalculationAlgorithm{

        private readonly StraightType _type;
        private const int LongStraightValue = 40;
        private const int ShortStraightValue = 30;

        public enum StraightType{
            Short = 1,
            Long =2
        }

        public StraightAlgorithm(StraightType type){
            _type = type;
        }

        public int Calculate(List<Die> Dice){

            if ( Dice == null ) throw new ArgumentNullException(Messages.DiceCannotBeNull);

            var sortedNumbers = from val in Dice
                                orderby val.Value
                                select val.Value;

            return _type == StraightType.Short ? CalculateShortStraight(sortedNumbers) : CalculateLongStraight(sortedNumbers);
        }

        private int CalculateLongStraight(IEnumerable<int> sortedNumbers){

            if (sortedNumbers.Contains(1) && sortedNumbers.Contains(2) && sortedNumbers.Contains(3) && sortedNumbers.Contains(4) && sortedNumbers.Contains(5))
            {
                return LongStraightValue;
            }

            if (sortedNumbers.Contains(2) && sortedNumbers.Contains(3) && sortedNumbers.Contains(4) && sortedNumbers.Contains(5) && sortedNumbers.Contains(6))
            {
                return LongStraightValue;
            }

            return 0;

        }

        private int CalculateShortStraight(IEnumerable<int> sortedNumbers){

            if (sortedNumbers == null) throw new ArgumentNullException("sortedNumbers");
            if (sortedNumbers.Contains(1) && sortedNumbers.Contains(2) && sortedNumbers.Contains(3) && sortedNumbers.Contains(4))
            {
                return ShortStraightValue;
            }

            if (sortedNumbers.Contains(2) && sortedNumbers.Contains(3) && sortedNumbers.Contains(4) && sortedNumbers.Contains(5))
            {
                return ShortStraightValue;
            }

            if (sortedNumbers.Contains(3) && sortedNumbers.Contains(4) && sortedNumbers.Contains(5) && sortedNumbers.Contains(6))
            {
                return ShortStraightValue;
            }

            return 0; 
        }
    }
}
