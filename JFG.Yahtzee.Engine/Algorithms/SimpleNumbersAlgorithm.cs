using System;
using System.Collections.Generic;
using JFG.Yahtzee.Engine.GameElements;

namespace JFG.Yahtzee.Engine.Algorithms{
    internal class SimpleNumbersAlgorithm : ICalculationAlgorithm{

        private readonly int _number;

        public SimpleNumbersAlgorithm( int number )
        {
            ValidateNumber(number);
            _number = number;
        }

        private void ValidateNumber(int number)
        {
           if (number <1 || number > 6)
               throw new ArgumentOutOfRangeException("number", number, Messages.InvalidSimpleNumber);
        }

  
        public int Calculate(List<Die> Dice)
        {
            var valuesFound = Dice.FindAll(dice => dice.Value == _number);
            return valuesFound.Count * _number;
        }
    }
}
