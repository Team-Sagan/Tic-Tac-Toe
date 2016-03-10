namespace Tic_Tack_Toe.Presenters
{
    using System.Threading;

    using Tic_Tack_Toe.EventArgs;
    using Tic_Tack_Toe.Interfaces;

    public class SinglePlayerGameBoardPresenter : MultiPlayerGameBoardPresenter
    {
        private readonly ISinglePlayerGameBoardModel model;

        private readonly ISinglePlayerGameBoardView view;

        public SinglePlayerGameBoardPresenter(ISinglePlayerGameBoardView view, ISinglePlayerGameBoardModel model)
            : base(view, model)
        {
            this.model = model;
            this.view = view;
            this.view.ComputerTurn += this.ComputerTurn;
        }

        private void ComputerTurn(object sender, ComputerTurnEventArgs e)
        {
            if (this.model.SecondPlayer.IsOnTurn)
            {
                var buttonCoordinates = this.model.ComputerMove();
                var x = buttonCoordinates[0] * e.Size;
                var y = buttonCoordinates[1] * e.Size;
                this.model.PlayerMoved(e.Size, x, y);
                this.view.DisplayComputerTurn(x, y);
            }
        }
    }
}