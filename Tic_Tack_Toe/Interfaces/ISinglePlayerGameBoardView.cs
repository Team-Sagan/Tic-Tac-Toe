namespace Tic_Tack_Toe.Interfaces
{
    using System;

    using Tic_Tack_Toe.EventArgs;

    public interface ISinglePlayerGameBoardView : IGameBoardView
    {
        event EventHandler<ComputerTurnEventArgs> ComputerTurn;

        void DisplayComputerTurn(int xCoordinate, int yCoordinate);
    }
}