namespace Tic_Tack_Toe.EventArgs
{
    using System;

    public class ComputerTurnEventArgs : EventArgs
    {
        public ComputerTurnEventArgs(int size)
        {
            this.Size = size;
        }

        public int Size { get; set; }
    }
}