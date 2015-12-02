using System;

namespace TicTacToeWinForms
{
    [Serializable]
    public class GameRecord
    {
        public DateTime Timestamp { get; set; }
        public string Winner { get; set; }
        public long Duration { get; set; }
    }
}
