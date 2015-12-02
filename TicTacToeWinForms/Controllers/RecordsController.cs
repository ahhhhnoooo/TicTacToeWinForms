using System.Collections.Generic;

namespace TicTacToeWinForms
{
    public class RecordsController
    {
        public IEnumerable<GameRecord> GetData()
        {
            var dbHelper = new GameRecordsDatabaseHelper();
            dbHelper.Open();
            IEnumerable<GameRecord> data = dbHelper.LoadAll();
            dbHelper.Close();
            return data;
        }
    }
}
