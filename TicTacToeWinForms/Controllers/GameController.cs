using System;
using System.IO;
using System.Threading;

namespace TicTacToeWinForms
{
    public class GameController
    {
        public GameModel Model { get { return _model; } }
        private GameModel _model;

        public GameController()
        {
            _model = new GameModel();
        }

        public void OnClickGameBoard(int index)
        {
            //Ignore click if game ended, start game if not started
            if (_model.Status == GameModel.GameStatus.Ended) return;
            else if (_model.Status == GameModel.GameStatus.Setup) _model.Status = GameModel.GameStatus.Started;

            //Ignore if spot already taken
            if (_model.GetBoardPosition(index) != 0) return;

            //Set spot and notify view
            _model.SetBoardPosition(index, _model.Turn);

            //Check winner
            if (checkWinnerBoard()) return;

            _model.NextTurn();

        }

        public void OnTickGameTimer()
        {
            if (_model.Status == GameModel.GameStatus.Setup
             || _model.Status == GameModel.GameStatus.Ended) return;
            ++_model.Duration;
        }

        public void OnClickResetButton()
        {
            _model.Reset();
        }

        private bool checkWinnerBoard()
        {
            //Check 3 rows, 3 cols, 2 diag
            return (
                    checkWinnerRow(0, 1, 2) ||
                    checkWinnerRow(3, 4, 5) ||
                    checkWinnerRow(6, 7, 8) ||
                    checkWinnerRow(0, 3, 6) ||
                    checkWinnerRow(1, 4, 7) ||
                    checkWinnerRow(2, 5, 8) ||
                    checkWinnerRow(0, 4, 8) ||
                    checkWinnerRow(2, 4, 6)
            );
            //TODO If board is full with no winner
        }

        /// <summary>
        /// Check if this is a winning set
        /// </summary>
        /// <returns>True if winner</returns>
        private bool checkWinnerRow(int a, int b, int c)
        {
            if (_model.Turn == _model.GetBoardPosition(a)
             && _model.Turn == _model.GetBoardPosition(b)
             && _model.Turn == _model.GetBoardPosition(c))
            {
                //Stop game, disables timer and board
                _model.Status = GameModel.GameStatus.Ended;

                //Notify winner
                _model.WinningPositions = new int[] { a, b, c };

                //Save results on another thread
                new Thread(() =>
                {
                    var record = new GameRecord()
                    {
                        Timestamp = DateTime.Now,
                        Winner = _model.Turn == GameModel.X ? "x" : "o",
                        Duration = _model.Duration
                    };
                    var dbHelper = new GameRecordsDatabaseHelper();
                    dbHelper.Open();
                    dbHelper.Save(record);
                    dbHelper.Close();
                }).Start();

                return true;
            }
            else return false;
        }
    }
}
