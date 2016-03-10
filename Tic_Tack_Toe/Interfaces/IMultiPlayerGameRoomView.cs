namespace Tic_Tack_Toe.Interfaces
{
    using System;

    using Tic_Tack_Toe.EventArgs;

    public interface IMultiPlayerGameBoardView
    {
        event EventHandler PlayerIconSet;

        event EventHandler<ButtonEventArgs> PlayerMove;

        IPlayer Player { get; set; }

        void GameDraw();

        void GameWon(IPlayer winner);

        void ResetGameBoard();
    }
}