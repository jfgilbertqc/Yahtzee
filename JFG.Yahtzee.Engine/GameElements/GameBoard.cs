using JFG.Yahtzee.Engine.RollTypes;

namespace JFG.Yahtzee.Engine.GameElements {
    
    public class GameBoard {
        public RollType Ones { get; set; }
        public RollType Twos { get; set; }
        public RollType Threes { get; set; }
        public RollType Fours { get; set; }
        public RollType Fives { get; set; }
        public RollType Sixes { get; set; }
        public RollType ThreeKind { get; set; }
        public RollType FourKind { get; set; }
        public RollType FullHouse { get; set; }
        public RollType ShortStraight { get; set; }
        public RollType LongStraight { get; set; }
        public RollType Chance { get; set; }
        public RollType Greens { get; set; }
        public RollType Reds { get; set; }
        public RollType Yellows { get; set; }
        public RollType ColoredFullHouse { get; set; }
        public RollType FiveKind { get; set; }
        public Player Player { get; set; }
    }
}
