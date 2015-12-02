using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TicTacToeWinForms
{
    class GameRecordsDatabaseHelper
    {
        //TODO Use a real Database...
        public bool Ready { private set; get; }
        private List<GameRecord> records = new List<GameRecord>();

        public GameRecordsDatabaseHelper()
        {
        }

        public void Open()
        {
            if (File.Exists("GameRecords.bin"))
            {
                using (var fakeDB = File.OpenRead("GameRecords.bin"))
                {
                    BinaryFormatter deserializer = new BinaryFormatter();
                    records = (List<GameRecord>)deserializer.Deserialize(fakeDB);
                    fakeDB.Close();
                }
            }
        }

        public void Close()
        {
            using (var fakeDB = File.Create("GameRecords.bin"))
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fakeDB, records);
                fakeDB.Close();
            }
        }

        public void Save(GameRecord record)
        {
            records.Add(record);
        }

        public IEnumerable<GameRecord> LoadAll()
        {
            return records;
        }

        public void Clear()
        {
            File.Delete("GameRecords.bin");
            records = new List<GameRecord>();
        }
    }
}
