namespace Tic_Tack_Toe.Interfaces
{
    public interface IEngine
    {
        /// <summary>
        /// Check for tree of same kind buttons
        /// </summary>
        void Check();

        /// <summary>
        /// Resets the game
        /// </summary>
        void Reset();
    }
}