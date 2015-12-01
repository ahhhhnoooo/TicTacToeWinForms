namespace TicTacToeWinForms
{
    public class MainController
    {
        public void OnClickNewGame(MainForm form)
        {
            //Set it up to return to main menu after closing
            var nextForm = new GameForm(new GameController());
            nextForm.FormClosed += delegate { form.Show(); };
            nextForm.Show();
            form.Hide();
        }

        public void OnClickRecords(MainForm form)
        {
            //Set it up to return to main menu after closing
            var nextForm = new RecordsForm(new RecordsController());
            nextForm.FormClosed += delegate { form.Show(); };
            nextForm.Show();
            form.Hide();
        }

        public void OnClickExit(MainForm form)
        {
            //TODO clean up
        }
    }
}
