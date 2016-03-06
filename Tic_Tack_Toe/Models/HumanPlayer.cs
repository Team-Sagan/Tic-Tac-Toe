namespace Tic_Tack_Toe.Models
{
    using Tic_Tack_Toe.Interfaces;

    public class HumanPlayer : Player
    {
        public HumanPlayer(string playerName, string playerSymbol)
            : base(playerName, playerSymbol)
        {
        }
    }
}