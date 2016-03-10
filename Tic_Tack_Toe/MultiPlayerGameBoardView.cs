namespace Tic_Tack_Toe
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using Tic_Tack_Toe.EventArgs;
    using Tic_Tack_Toe.Interfaces;
    using Tic_Tack_Toe.Models;
    using Tic_Tack_Toe.Presenters;
    using Tic_Tack_Toe.Resources;

    public partial class MultiPlayerGameBoardView : Form, IMultiPlayerGameBoardView
    {
        private IMultiPlayerGameBoardPresenter presenter;

        public MultiPlayerGameBoardView(IPlayer firstPlayer, IPlayer secondPlayer)
        {
            this.InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            firstPlayer.ActivateTurn();

            var gameBoardModel = new MultiPlayerGameBoardModel(firstPlayer, secondPlayer);
            this.presenter = new MultiPlayerGameBoardPresenter(this, gameBoardModel);
        }

        public event EventHandler PlayerIconSet;

        public event EventHandler<ButtonEventArgs> PlayerMove;

        public IPlayer Player { get; set; }

        public void ResetGameBoard()
        {
            foreach (var button in
                this.Controls.Cast<Button>()
                    .Where(
                        button =>
                        button.Text != Messages.MainMenu && button.Text != Messages.Exit && button.Text != Messages.Back)
                )
            {
                button.Text = string.Empty;
            }
        }

        void IMultiPlayerGameBoardView.GameDraw()
        {
            var result = MessageBox.Show(Messages.DrawMessage);
            if (result == DialogResult.OK)
            {
                this.ResetGameBoard();
            }
        }

        void IMultiPlayerGameBoardView.GameWon(IPlayer winner)
        {
            var result = MessageBox.Show(
                string.Format(Messages.WinMessage, winner.PlayerName), 
                Messages.Congratulations);
            if (result == DialogResult.OK)
            {
                this.ResetGameBoard();
            }
        }

        private void ButtonBackClicked(object sender, System.EventArgs e)
        {
            var message = MessageBox.Show(
                Messages.PossibleProgressLoss, 
                Messages.Information, 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Exclamation);
            if (message == DialogResult.OK)
            {
                this.Hide();
                var customScreen = new MultiPlayerUserSetUpView();
                customScreen.ShowDialog();
                this.Close();
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
                this.btnFocused.Focus();
            }
        }

        private void ButtonExitClicked(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ButtonMainMenuClicked(object sender, System.EventArgs e)
        {
            var message = MessageBox.Show(
                Messages.PossibleProgressLoss, 
                Messages.Information, 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Exclamation);
            if (message == DialogResult.OK)
            {
                this.Hide();
                var gameEntry = new GameEntry();
                gameEntry.ShowDialog();
                this.Close();
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
    }
}