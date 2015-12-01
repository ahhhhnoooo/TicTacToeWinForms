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
            _model.OnClickedBoard(index);
        }

        public void OnTickGameTimer()
        {
            _model.OnTickGameTimer();
        }

        public void OnClickResetButton()
        {
            _model.Reset();
        }
    }
}
