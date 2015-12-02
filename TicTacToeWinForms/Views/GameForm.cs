using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeWinForms
{
    public partial class GameForm : Form
    {
        private GameController controller;
        private PictureBox[] boardView;

        public GameForm(GameController c)
        {
            controller = c;
            InitializeComponent();
            boardView = new PictureBox[]{
                game_board_0,game_board_1,game_board_2,
                game_board_3,game_board_4,game_board_5,
                game_board_6,game_board_7,game_board_8
            };
            //TODO use databindings
            //game_duration_label.DataBindings.Add("Text", controller.Model, "Duration");
            controller.Model.PropertyChanged += Model_PropertyChanged;
        }

        private void Model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            GameModel model = (GameModel)sender;
            switch (e.PropertyName)
            {
                //TODO Format duration into time?
                case "Duration":
                    {
                        game_duration_label.Text = model.Duration.ToString();
                    }
                    break;
                case "Turn":
                    {
                        if (model.Turn == GameModel.X) game_turn_image.Image = Properties.Resources.x;
                        else game_turn_image.Image = Properties.Resources.o;
                    }
                    break;
                case "Winner":
                    {
                        if (model.WinningPositions != null)
                        {
                            Image winnerImage;
                            if (model.Turn == GameModel.X) winnerImage = Properties.Resources.xwin;
                            else winnerImage = Properties.Resources.owin;

                            foreach (int index in model.WinningPositions)
                            {
                                boardView[index].Image = winnerImage;
                            }
                            game_turn_label.Text = "WINNER";
                        }
                        else
                        {
                            game_turn_label.Text = "turn";
                        }
                    }
                    break;
                default:
                    {
                        int index = Convert.ToInt32(e.PropertyName);
                        switch (model.GetBoardPosition(index))
                        {
                            case GameModel.O: boardView[index].Image = Properties.Resources.o; break;
                            case GameModel.BLANK: boardView[index].Image = Properties.Resources.blank; break;
                            case GameModel.X: boardView[index].Image = Properties.Resources.x; break;
                        }
                    }
                    break;
            }
        }

        private void game_board_Click(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            //TODO use custom Button to make this safer
            controller.OnClickGameBoard(Convert.ToInt32(b.Tag));
        }

        private void game_timer_Tick(object sender, EventArgs e)
        {
            controller.OnTickGameTimer();
        }

        private void game_reset_button_Click(object sender, EventArgs e)
        {
            controller.OnClickResetButton();
            //Allow model to notify to reset view
        }
    }
}
