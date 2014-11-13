using System;
using System.Collections.Generic;

namespace JFG.Yahtzee.Engine.GameElements
{
    public class Game
    {

        private const int MaxNumberOfPlayers = 4;
        private const int MinNumberOfPlayers = 1;

        public Game( int numberOfPlayers )
        {
            ValidateNumberOfPlayers(numberOfPlayers);
            InitializeEntity();
            CreatePlayers(numberOfPlayers);
            CreateBoards(numberOfPlayers);

        }

        private void ValidateNumberOfPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers < MinNumberOfPlayers || numberOfPlayers > MaxNumberOfPlayers)
            {
                throw new ArgumentOutOfRangeException("numberOfPlayers", numberOfPlayers,
                                                     Messages.NumberOfPlayersValidation);
            }
        }

        public List<Player> Players { get; private set; }
        public List<GameBoard> Boards { get; private set; }
        public DateTime Date { get; private set; }


        private void InitializeEntity()
        {
            Players = new List<Player>();
            Boards = new List<GameBoard>();
            Date = DateTime.Now;
        }

        private void CreatePlayers( int numberOfPlayers)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                var player = new Player {Name = "Player" + (i+1)};
                Players.Add( player);
            }
        }

        private void CreateBoards(int numberOfPlayers) {
            for (int i    = 0; i < numberOfPlayers; i++) {
                var board = new GameBoard() { Player = Players[i] };
                Boards.Add(board);
            }
        }
    }
}
