using System.Collections.Generic;
using System.Linq;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.Algorithms {
    internal class ColorsAlgorithm : ICalculationAlgorithm {

        private const int ColorPoints = 40;

        public ColorsAlgorithm(DieColor color, int numberOfTimes) {
            Color = color;
            NumberOfTimes = numberOfTimes;
        }

        public int Calculate(List<Die> Dice) {
            var numberOfOccurences =
                from dice in Dice
                group dice by dice.Color
                    into occurences
                    select new { occurences.Key, Count = occurences.Count() };

            var ofAColor = numberOfOccurences.ToList().Find(occurences => occurences.Count == NumberOfTimes);

            if (ofAColor != null && ofAColor.Key == Color)
                return ColorPoints;

            return 0;
        }

        public DieColor Color { get; set; }
        public int NumberOfTimes { get; set; }
    }

}
