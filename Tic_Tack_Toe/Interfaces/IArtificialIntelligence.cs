namespace Tic_Tack_Toe.Interfaces
{
    public interface IArtificialIntelligence
    {
        /// <summary>
        /// Returns the computer move in a game of tic tac toe.
        /// </summary>
        /// <param name="ticTacToe">Two dimensional 3 by 3 string array showing the current state of the game.</param>
        /// <returns>Returns an array with count 2 that holds on index 0 the row and on index 1 the column of 
        /// the computer move in a 3 by 3 string matrix of the game.</returns>
        int[] AiMove(string[,] ticTacToe);
    }
}