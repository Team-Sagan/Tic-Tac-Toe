namespace Tic_Tack_Toe.Models
{
    /// <summary>
    /// Main logic for artificial intelligence
    /// </summary>
    public class Computer : Player
    {
        private const string ComputerName = "Computer";

        public Computer(string computerSymbol)
            : base(ComputerName, computerSymbol)
        {
           // this.PlayerSymbol = computerSymbol;
        }
    }
}