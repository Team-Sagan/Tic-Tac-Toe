namespace Tic_Tack_Toe
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using Tic_Tack_Toe.EventArgs;
    using Tic_Tack_Toe.Interfaces;
    using Tic_Tack_Toe.Models;
    using Tic_Tack_Toe.Presenters;

    public partial class GameBoardView : Form, IGameBoardView
    {
        private IGameBoardPresenter presenter;

        public GameBoardView()
        {
            this.InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.presenter = new GameBoardPresenter(
                this, 
                new GameBoardModel(new Player("Koko", "X") { IsOnTurn = true }, new Player("Boko", "O")));
        }

        public event EventHandler CheckForDraw;

        public event EventHandler CheckForWinner;

        public event EventHandler<ButtonEventArgs> PlayerMove;

        public IPlayer Player { get; set; }

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
                this.OnCheckForWinner();
                this.OnCheckForDraw();
                this.btnFocused.Focus();
            }
        }

        private void OnCheckForDraw()
        {
            if (this.CheckForDraw != null)
            {
                this.CheckForDraw(this, System.EventArgs.Empty);
            }
        }

        private void OnCheckForWinner()
        {
            if (this.CheckForWinner != null)
            {
                this.CheckForWinner(this, System.EventArgs.Empty);
            }
        }

        private void OnPlayerMove(ButtonEventArgs e)
        {
            if (this.PlayerMove != null)
            {
                this.PlayerMove(this, e);
            }
        }
    }
}