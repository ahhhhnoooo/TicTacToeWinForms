using System.Windows.Forms;

namespace TicTacToeWinForms
{
    public partial class RecordsForm : Form
    {
        private RecordsController controller;

        public RecordsForm(RecordsController c)
        {
            controller = c;
            InitializeComponent();
        }
    }
}
