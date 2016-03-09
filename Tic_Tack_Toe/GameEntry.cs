namespace Tic_Tack_Toe
{
    using System.Windows.Forms;

    public partial class GameEntry : Form
    {
        public GameEntry()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var singlePlayerGame = new SinglePlayerGameBoardView();
            singlePlayerGame.Show();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            var customScreen = new CustomisationScreen();
            customScreen.Show();
            //var multyPlayerGame = new GameBoardView();

            //multyPlayerGame.Show();
        }
    }
}