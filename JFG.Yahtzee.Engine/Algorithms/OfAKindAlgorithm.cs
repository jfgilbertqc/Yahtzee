using System.Collections.Generic;
using System.Linq;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.Algorithms {
    internal class OfAKindAlgorithm : ICalculationAlgorithm {
        private readonly int _numberOfAKind;

        public OfAKindAlgorithm(int numberOfAKind) {
            _numberOfAKind = numberOfAKind;
        }

        public int Calculate(List<Die> Dice) {
            var numberOfOccurences =
                 from dice in Dice
                 group dice by dice.Value into occurences
                 select new { occurences.Key, Count = occurences.Count() };

            var ofAKindFound = numberOfOccurences.ToList().Find(occurences => occurences.Count == _numberOfAKind);

            if (ofAKindFound != null) {
                var total = (from dice in Dice
                             select dice.Value).Sum();
                return total;
            }
            return 0;
        }

    }
}
