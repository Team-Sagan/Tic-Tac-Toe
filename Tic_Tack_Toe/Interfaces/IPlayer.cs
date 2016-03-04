namespace Tic_Tack_Toe.Interfaces
{
    public interface IPlayer
    {
        bool IsOnTurn { get; }

        bool IsWinner { get; }

        string PlayerName { get; }

        string PlayerSymbol { get; }

        void ActivateTurn();

        void DeactivateTurn();

        void ResetPlayer();

        void SetWinner();
    }
}