namespace Tic_Tack_Toe
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using Tic_Tack_Toe.EventArgs;
    using Tic_Tack_Toe.Interfaces;
    using Tic_Tack_Toe.Models;
    using Tic_Tack_Toe.Presenters;

    public partial class SinglePlayerGameBoardView : Form, ISinglePlayerGameBoardView
    {
        private IGameBoardPresenter presenter;

        public SinglePlayerGameBoardView()
        {
            this.InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            var firstPlayer = new HumanPlayer("Koko", "X") { IsOnTurn = true };
            var secondPlayer = new Computer("O");
            var gameBoardModel = new SinglePlayerGameRoomModel(firstPlayer, secondPlayer);
            this.presenter = new SinglePlayerGameBoardPresenter(this, gameBoardModel);
        }

        public event EventHandler<ComputerTurnEventArgs> ComputerTurn;

        public event EventHandler PlayerIconSet;

        public event EventHandler<ButtonEventArgs> PlayerMove;

        public IPlayer Player { get; set; }

        public void DisplayComputerTurn(int xCoordinate, int yCoordinate)
        {
            foreach (var btn in
                this.Controls.Cast<Button>()
                    .Where(btn => btn.Location.X == xCoordinate && btn.Location.Y == yCoordinate))
            {
                btn.Text = this.Player.PlayerSymbol;
            }
        }

        public void ResetGameBoard()
        {
            foreach (var button in this.Controls.Cast<Button>())
            {
                button.Text = string.Empty;
            }
        }

        void IGameBoardView.GameDraw()
        {
            var result = MessageBox.Show(@"Game Draw!");
            if (result == DialogResult.OK)
            {
                this.ResetGameBoard();
            }
        }

        void IGameBoardView.GameWon(IPlayer winner)
        {
            var result = MessageBox.Show(string.Format("Player {0} wins!", winner.PlayerName), @"Congratulations!");
            if (result == DialogResult.OK)
            {
                this.ResetGameBoard();
            }
        }

        private void ButtonClick(object sender, System.EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == string.Empty)
            {
                this.OnPlayerMove(new ButtonEventArgs(button.Size.Height, button.Location.X, button.Location.Y));
                button.Text = this.Player.PlayerSymbol;
                this.OnPlayerIconSet();
                this.OnComputerTurn(new ComputerTurnEventArgs(button.Size.Height));
                this.OnPlayerIconSet();
                this.btnFocused.Focus();
            }
        }

        private void OnComputerTurn(ComputerTurnEventArgs sizeEventArgs)
        {
            if (this.ComputerTurn != null)
            {
                this.ComputerTurn(this, sizeEventArgs);
            }
        }

        private void OnPlayerIconSet()
        {
            if (this.PlayerIconSet != null)
            {
                this.PlayerIconSet(this, System.EventArgs.Empty);
            }
        }

        private void OnPlayerMove(ButtonEventArgs e)
        {
            if (this.PlayerMove != null)
            {
                this.PlayerMove(this, e);
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            var message = MessageBox.Show("If you leave you will loose your progress!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (message == DialogResult.OK)
            {
                var gameEntry = new GameEntry();
                gameEntry.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}