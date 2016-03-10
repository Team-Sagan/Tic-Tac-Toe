namespace Tic_Tack_Toe.Exceptions
{
    using System;

    public class InvalidPlayerNameException : Exception
    {
        public InvalidPlayerNameException()
        {
        }

        public InvalidPlayerNameException(string message)
            : base(message)
        {
        }
    }
}