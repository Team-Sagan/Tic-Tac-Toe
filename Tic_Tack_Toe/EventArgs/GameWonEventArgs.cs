namespace Tic_Tack_Toe.EventArgs
{
    using System;

    using Tic_Tack_Toe.Interfaces;

    public class GameWonEventArgs : EventArgs
    {
        public GameWonEventArgs(IPlayer winner)
        {
            this.Winner = winner;
        }

        public IPlayer Winner { get; private set; }
    }
}