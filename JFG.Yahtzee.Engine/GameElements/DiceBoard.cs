using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFG.Yahtzee.Engine.GameElements {
    public class DiceBoard {

        public List<Die> Dice { get; set; }

        public void Roll()
        {
            InitializeEntity();
        }

        private void InitializeEntity()
        {
            Dice = new List<Die>();
        }
    }
}
