using System;
using System.Windows.Forms;

namespace TicTacToeWinForms
{
    public partial class MainForm : Form
    {
        private MainController controller;

        public MainForm(MainController c)
        {
            controller = c;
            InitializeComponent();
        }

        private void main_newgame_button_Click(object sender, EventArgs e)
        {
            controller.OnClickNewGame(this);
        }

        private void main_records_button_Click(object sender, EventArgs e)
        {
            controller.OnClickRecords(this);
        }

        private void main_exit_button_Click(object sender, EventArgs e)
        {
            //Allow controller to clean up
            controller.OnClickExit(this);
            Application.Exit();
        }
    }
}
