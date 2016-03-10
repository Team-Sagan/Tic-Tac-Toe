namespace Tic_Tack_Toe
{
    using System.Windows.Forms;

    public partial class GameEntry : Form
    {
        public GameEntry()
        {
            this.InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ButtonExitClicked(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ButtonVsComputerClicked(object sender, System.EventArgs e)
        {
            this.Hide();
            var singlePlayerGame = new SinglePlayerGameBoardView();
            singlePlayerGame.ShowDialog();
            this.Close();
        }

        private void ButtonVsPlayerClicked(object sender, System.EventArgs e)
        {
            this.Hide();
            var customScreen = new MultiPlayerUserSetUpView();
            customScreen.ShowDialog();
            this.Close();
        }
    }
}