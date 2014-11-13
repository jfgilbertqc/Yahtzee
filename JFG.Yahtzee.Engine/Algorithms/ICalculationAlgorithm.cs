using System.Collections.Generic;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.Algorithms{
    public interface ICalculationAlgorithm{

        int Calculate(List<Die> Dice);
    }
}
