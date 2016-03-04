namespace Tic_Tack_Toe.EventArgs
{
    using System;

    public class ButtonEventArgs : EventArgs
    {
        public ButtonEventArgs(int size, int x, int y)
        {
            this.Size = size;
            this.X = x;
            this.Y = y;
        }
        public int Size { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}