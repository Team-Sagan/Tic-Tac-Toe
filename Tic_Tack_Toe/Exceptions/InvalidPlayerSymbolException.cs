namespace Tic_Tack_Toe.Exceptions
{
    using System;

    public class InvalidPlayerSymbolException : Exception
    {
        public InvalidPlayerSymbolException()
        {
        }

        public InvalidPlayerSymbolException(string message)
            : base(message)
        {
        }
    }
}