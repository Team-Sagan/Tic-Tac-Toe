namespace Tic_Tack_Toe
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using Tic_Tack_Toe.Character;
    using Tic_Tack_Toe.EventArgs;
    using Tic_Tack_Toe.Interfaces;
    using Tic_Tack_Toe.Models;
    using Tic_Tack_Toe.Presenters;

    public partial class GameBoardView : Form, IGameBoardView
    {
        private readonly GameBoardModel gameBoardModel;
        private readonly IPlayer firstPlayer;
        private readonly Computer secondPlayer;
        private IGameBoardPresenter presenter;

        public GameBoardView()
        {
            this.InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.firstPlayer = new HumanPlayer("Koko", "X") { IsOnTurn = true };
            this.secondPlayer = new Computer("O", "X");
            this.gameBoardModel = new GameBoardModel(this.firstPlayer, this.secondPlayer);
            this.presenter = new GameBoardPresenter(this, this.gameBoardModel);
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

                if (this.secondPlayer.IsOnTurn)
                {
                    var computerMove = this.secondPlayer.AiMove(this.gameBoardModel.GameBoard);
                    int computerX = computerMove[0] * button.Size.Height; ////col
                    int computerY = computerMove[1] * button.Size.Height; ////row
                    this.ShowComputerMove(computerX, computerY);
                    this.OnPlayerMove(new ButtonEventArgs(button.Size.Height, computerX, computerY));
                    this.OnCheckForWinner();
                    this.OnCheckForDraw();
                    this.btnFocused.Focus();
                }
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

        private void ShowComputerMove(int computerX, int computerY)
        {
            if (computerY == 0)
            {
                switch (computerX)
                {
                    case 0:
                        this.A1.Text = this.secondPlayer.PlayerSymbol;
                        break;
                    case 100:
                        this.A2.Text = this.secondPlayer.PlayerSymbol;
                        break;
                    case 200:
                        this.A3.Text = this.secondPlayer.PlayerSymbol;
                        break;
                }
            }
            else if (computerY == 100)
            {
                switch (computerX)
                {
                    case 0:
                        this.B1.Text = this.secondPlayer.PlayerSymbol;
                        break;
                    case 100:
                        this.B2.Text = this.secondPlayer.PlayerSymbol;
                        break;
                    case 200:
                        this.B3.Text = this.secondPlayer.PlayerSymbol;
                        break;
                }
            }
            else
            {
                switch (computerX)
                {
                    case 0:
                        this.C1.Text = this.secondPlayer.PlayerSymbol;
                        break;
                    case 100:
                        this.C2.Text = this.secondPlayer.PlayerSymbol;
                        break;
                    case 200:
                        this.C3.Text = this.secondPlayer.PlayerSymbol;
                        break;
                }
            }
        }
    }
}