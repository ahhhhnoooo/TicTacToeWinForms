using System.ComponentModel;

namespace TicTacToeWinForms
{
    public class GameModel : INotifyPropertyChanged
    {
        public const int X = 1;
        public const int O = -1;
        public const int BLANK = 0;

        public enum GameStatus
        {
            Unknown,
            Setup,
            Started,
            Ended
        }

        private GameStatus _status;
        private int _turn;
        private long _duration;
        private int[] _board;
        private int[] _winningPositions;

        public event PropertyChangedEventHandler PropertyChanged;

        public GameModel()
        {
            _board = new int[9];
            Reset();
        }

        /// <summary>
        /// Duration of the game in seconds
        /// </summary>
        public long Duration
        {
            set
            {
                if (_duration != value)
                {
                    _duration = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Duration"));
                }
            }
            get
            {
                return _duration;
            }
        }

        /// <summary>
        /// Player who's turn it is
        /// </summary>
        public int Turn
        {
            private set
            {
                if (_turn != value)
                {
                    _turn = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Turn"));
                }
            }
            get { return _turn; }
        }

        /// <summary>
        /// Status of the game
        /// </summary>
        public GameStatus Status
        {
            set
            {
                if (_status != value)
                {
                    _status = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Status"));
                }
            }
            get { return _status; }
        }

        /// <summary>
        /// The indices of the board positions that make a winning match
        /// Null if no winner
        /// </summary>
        public int[] WinningPositions
        {
            set
            {
                _winningPositions = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Winner"));
            }
            get
            {
                return _winningPositions;
            }
        }

        public void SetBoardPosition(int index, int value)
        {
            //Check out of range
            if (index >= 9) return;

            if (_board[index] != value)
            {
                _board[index] = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(index.ToString()));
            }
        }

        public int GetBoardPosition(int index)
        {
            return _board[index];
        }

        /// <summary>
        /// Advance turn and notify view
        /// </summary>
        public void NextTurn()
        {
            if (Turn == X) Turn = O;
            else Turn = X;
        }

        /// <summary>
        /// Reset the game
        /// </summary>
        public void Reset()
        {
            //TODO First second is not full second
            for (int index = 0; index < 9; ++index)
            {
                _board[index] = 0;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(index.ToString()));
            }

            //Use properties to trigger notification
            Duration = 0;
            Turn = X;
            WinningPositions = null;
            Status = GameStatus.Setup;
        }
    }
}
