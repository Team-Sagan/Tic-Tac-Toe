namespace Tic_Tack_Toe.Models
{
    using Tic_Tack_Toe.Interfaces;

    public abstract class Player : IPlayer
    {
        protected Player(string playerName, string playerSymbol)
        {
            this.PlayerName = playerName;
            this.PlayerSymbol = playerSymbol;
            this.IsOnTurn = false;
            this.IsWinner = false;
        }

        public bool IsOnTurn { get; set; }

        public bool IsWinner { get; private set; }

        public string PlayerName { get; private set; }

        public string PlayerSymbol { get; protected set; }

        public void ActivateTurn()
        {
            this.IsOnTurn = true;
        }

        public void DeactivateTurn()
        {
            this.IsOnTurn = false;
        }

        public void ResetPlayer()
        {
            this.IsWinner = false;
            this.IsOnTurn = false;
        }

        public void SetWinner()
        {
            this.IsWinner = true;
        }
    }
}
