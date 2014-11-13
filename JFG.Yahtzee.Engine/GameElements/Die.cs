using System;

namespace JFG.Yahtzee.Engine.GameElements{
    public class Die{

      public void Roll(){
            var random = new Random();
            Color = (DieColor)random.Next(1, 3);

            random = new Random();
            Value = random.Next(1, 6);
        }

        public int Value { get;  set; }
        public DieColor Color { get;  set; }
        public bool IsPicked { get; set; }
    }

    public enum DieColor {
        Green = 1,
        Red = 2,
        Yellow = 3
    }
}
