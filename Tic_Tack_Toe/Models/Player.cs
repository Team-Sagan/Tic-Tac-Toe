namespace Tic_Tack_Toe.Models
{
    using Tic_Tack_Toe.Exceptions;
    using Tic_Tack_Toe.Interfaces;

    public abstract class Player : IPlayer
    {
        private string playerName;

        private string playerSymbol;

        protected Player(string playerName, string playerSymbol)
        {
            this.PlayerName = playerName;
            this.PlayerSymbol = playerSymbol;
            this.IsOnTurn = false;
            this.IsWinner = false;
        }

        public bool IsOnTurn { get; set; }

        public bool IsWinner { get; private set; }

        public string PlayerName
        {
            get
            {
                return this.playerName;
            }

            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidPlayerNameException("Player name cannot be null, empty or whitespace!");
                }

                this.playerName = value;
            }
        }

        public string PlayerSymbol
        {
            get
            {
                return this.playerSymbol;
            }

           protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidPlayerSymbolException("Player symbol cannot be null, empty or whitespace!");
                }

                this.playerSymbol = value;
            }
        }

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