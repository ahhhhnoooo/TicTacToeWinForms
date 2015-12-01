using System.ComponentModel;

namespace TicTacToeWinForms
{
    public class GameModel : INotifyPropertyChanged
    {
        public const int X = 1;
        public const int O = -1;
        public const int BLANK = 0;

        public bool InProgress { private set; get; }
        public long Duration { private set; get; }
        public int Turn { private set; get; }
        public int[] Board { private set; get; }
        public int[] WinningPositions { private set; get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public GameModel()
        {
            Reset();
        }

        public void OnClickedBoard(int index)
        {
            if (InProgress == false) return;
            //Ignore if spot already taken
            if (Board[index] != 0) return;

            //Set spot and notify view
            Board[index] = Turn;
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(index.ToString()));

            //Check winner
            if (checkWinnerBoard()) return;

            //Advance turn and notify view
            if (Turn == X) Turn = O;
            else Turn = X;
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Turn"));

        }
        public void OnTickGameTimer()
        {
            if (InProgress == false) return;
            ++Duration;
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Duration"));
        }

        public void Reset()
        {
            //TODO First second is not full second
            Duration = 0;
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Duration"));

            Turn = X;
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Turn"));

            Board = new int[9];
            for (int i = 0; i < 9; ++i)
            {
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(i.ToString()));
            }

            WinningPositions = null;
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Winner"));

            InProgress = true;
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
            if (Turn == Board[a] && Turn == Board[b] && Turn == Board[c])
            {
                //Stop game, disables timer and board
                InProgress = false;

                WinningPositions = new int[] { a, b, c };

                //Notify winner
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Winner"));

                //Save results

                return true;
            }
            else return false;
        }
    }
}
