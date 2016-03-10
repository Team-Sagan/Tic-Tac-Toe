namespace Tic_Tack_Toe.Interfaces
{
    using System;

    using Tic_Tack_Toe.EventArgs;

    public interface IGameBoardModel
    {
        event EventHandler GameDraw;

        event EventHandler<GameWonEventArgs> GameWon;

        event EventHandler MovedPlayer;

        IPlayer FirstPlayer { get; }

        IPlayer SecondPlayer { get; }

        void DrawCheck();

        void PlayerMoved(int size, int x, int y);

        void ResetGameBoard();

        void WinCheck();
    }
}