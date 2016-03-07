namespace Tic_Tack_Toe.Presenters
{
    using System;

    using Tic_Tack_Toe.EventArgs;
    using Tic_Tack_Toe.Interfaces;

    public class GameBoardPresenter : IGameBoardPresenter
    {
        private readonly IGameBoardModel model;

        private readonly IGameBoardView view;

        public GameBoardPresenter(IGameBoardView view, IGameBoardModel model)
        {
            this.view = view;
            this.model = model;
            this.SetUp();
        }

        public virtual void PlayerMove(object sender, ButtonEventArgs eventArgs)
        {
            this.model.PlayerMoved(eventArgs.Size, eventArgs.X, eventArgs.Y);
        }

        private void CheckForDraw(object sender, EventArgs e)
        {
            this.model.DrawCheck();
        }

        private void CheckForWinner(object sender, EventArgs e)
        {
            this.model.WinCheck();
        }

        private void DrawGame(object sender, EventArgs e)
        {
            this.view.GameDraw();
            this.model.ResetGameBoard();
        }

        private void MovedPlayer(object sender, EventArgs e)
        {
            if (this.model.FirstPlayer.IsOnTurn)
            {
                this.view.Player = this.model.SecondPlayer;
            }
            else
            {
                this.view.Player = this.model.FirstPlayer;
            }
        }

        protected void SetUp()
        {
            this.view.PlayerMove += this.PlayerMove;
            this.view.PlayerIconSet += this.CheckForWinner;
            this.view.PlayerIconSet += this.CheckForDraw;
            this.model.GameDraw += this.DrawGame;
            this.model.GameWon += this.WonGame;
            this.model.MovedPlayer += this.MovedPlayer;
        }

        private void WonGame(object sender, GameWonEventArgs e)
        {
            this.view.GameWon(e.Winner);
            this.model.ResetGameBoard();
        }
    }
}