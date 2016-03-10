namespace Tic_Tack_Toe.Models
{
    using System;

    using Tic_Tack_Toe.EventArgs;
    using Tic_Tack_Toe.Interfaces;

    public class MultiPlayerGameBoardModel : IGameBoardModel
    {
        protected readonly string[,] GameBoard = new string[3, 3];

        protected int Counter;

        public MultiPlayerGameBoardModel(IPlayer firstPlayer, IPlayer secondPlayer)
        {
            this.FirstPlayer = firstPlayer;
            this.SecondPlayer = secondPlayer;
            this.SetGameBoard();
        }

        public event EventHandler GameDraw;

        public event EventHandler<GameWonEventArgs> GameWon;

        public event EventHandler MovedPlayer;

        public IPlayer FirstPlayer { get; private set; }

        public IPlayer SecondPlayer { get; private set; }

        public void DrawCheck()
        {
            if (this.Counter < this.GameBoard.Length)
            {
                return;
            }

            if (!this.FirstPlayer.IsWinner && !this.SecondPlayer.IsWinner)
            {
                this.OnGameDraw();
            }
        }

        public void PlayerMoved(int size, int x, int y)
        {
            x = x / size;
            y = y / size;
            var text = this.GameBoard[x, y];
            if (text == string.Empty)
            {
                this.Counter++;
                if (this.FirstPlayer.IsOnTurn)
                {
                    this.GameBoard[x, y] = this.FirstPlayer.PlayerSymbol;
                    this.FirstPlayer.DeactivateTurn();
                    this.SecondPlayer.ActivateTurn();
                    this.OnMovedPlayer();
                }
                else
                {
                    this.GameBoard[x, y] = this.SecondPlayer.PlayerSymbol;
                    this.SecondPlayer.DeactivateTurn();
                    this.FirstPlayer.ActivateTurn();
                    this.OnMovedPlayer();
                }
            }
        }

        public void ResetGameBoard()
        {
            this.SetGameBoardToDefaultValues();
            this.Counter = 0;
            this.FirstPlayer.ResetPlayer();
            this.FirstPlayer.ActivateTurn();
            this.SecondPlayer.ResetPlayer();
        }

        public void SetGameBoard()
        {
            for (var x = 0; x < this.GameBoard.GetLength(0); x++)
            {
                for (var y = 0; y < this.GameBoard.GetLength(1); y++)
                {
                    this.GameBoard[x, y] = string.Empty;
                }
            }
        }

        public void WinCheck()
        {
            if (this.Counter >= 5)
            {
                this.CheckHorizontally();
                this.CheckVertically();
                this.CheckMainDiagonal();
                this.CheckSecondaryDiagonal();
                if (this.FirstPlayer.IsWinner)
                {
                    this.OnGameWon(this.FirstPlayer);
                }
                else if (this.SecondPlayer.IsWinner)
                {
                    this.OnGameWon(this.SecondPlayer);
                }
            }
        }

        protected void OnMovedPlayer()
        {
            if (this.MovedPlayer != null)
            {
                this.MovedPlayer(this, EventArgs.Empty);
            }
        }

        private bool CheckForWinner(int firstPlayerCount, int secondPlayerCount)
        {
            if (firstPlayerCount == this.GameBoard.GetLength(0))
            {
                this.FirstPlayer.SetWinner();
                return true;
            }

            if (secondPlayerCount == this.GameBoard.GetLength(0))
            {
                this.SecondPlayer.SetWinner();
                return true;
            }

            return false;
        }

        private void CheckHorizontally()
        {
            for (var row = 0; row < this.GameBoard.GetLength(0); row++)
            {
                var firstPlayerCount = 1;
                var secondPlayerCount = 1;
                for (var col = 0; col < this.GameBoard.GetLength(1) - 1; col++)
                {
                    if (this.GameBoard[row, col] == this.GameBoard[row, col + 1]
                        && this.GameBoard[row, col] == this.FirstPlayer.PlayerSymbol)
                    {
                        firstPlayerCount++;
                    }

                    if (this.GameBoard[row, col] == this.GameBoard[row, col + 1]
                        && this.GameBoard[row, col] == this.SecondPlayer.PlayerSymbol)
                    {
                        secondPlayerCount++;
                    }
                }

                if (this.CheckForWinner(firstPlayerCount, secondPlayerCount))
                {
                    break;
                }
            }
        }

        private void CheckMainDiagonal()
        {
            var firstPlayerCount = 0;
            var secondPlayerCount = 0;
            for (var row = 0; row < this.GameBoard.GetLength(0); row++)
            {
                if (this.GameBoard[row, row] == this.FirstPlayer.PlayerSymbol)
                {
                    firstPlayerCount++;
                }

                if (this.GameBoard[row, row] == this.SecondPlayer.PlayerSymbol)
                {
                    secondPlayerCount++;
                }
            }

            this.CheckForWinner(firstPlayerCount, secondPlayerCount);
        }

        private void CheckSecondaryDiagonal()
        {
            var firstPlayerCount = 0;
            var secondPlayerCount = 0;
            for (var row = 0; row < this.GameBoard.GetLength(0); row++)
            {
                if (this.GameBoard[row, this.GameBoard.GetLength(1) - 1 - row] == this.FirstPlayer.PlayerSymbol)
                {
                    firstPlayerCount++;
                }

                if (this.GameBoard[row, this.GameBoard.GetLength(1) - 1 - row] == this.SecondPlayer.PlayerSymbol)
                {
                    secondPlayerCount++;
                }
            }

            this.CheckForWinner(firstPlayerCount, secondPlayerCount);
        }

        private void CheckVertically()
        {
            for (var col = 0; col < this.GameBoard.GetLength(1); col++)
            {
                var firstPlayerCount = 1;
                var secondPlayerCount = 1;
                for (var row = 0; row < this.GameBoard.GetLength(0) - 1; row++)
                {
                    if (this.GameBoard[row, col] == this.GameBoard[row + 1, col]
                        && this.GameBoard[row, col] == this.FirstPlayer.PlayerSymbol)
                    {
                        firstPlayerCount++;
                    }

                    if (this.GameBoard[row, col] == this.GameBoard[row + 1, col]
                        && this.GameBoard[row, col] == this.SecondPlayer.PlayerSymbol)
                    {
                        secondPlayerCount++;
                    }
                }

                if (this.CheckForWinner(firstPlayerCount, secondPlayerCount))
                {
                    break;
                }
            }
        }

        private void OnGameDraw()
        {
            if (this.GameDraw != null)
            {
                this.GameDraw(this, EventArgs.Empty);
            }
        }

        private void OnGameWon(IPlayer winner)
        {
            if (this.GameWon != null)
            {
                this.GameWon(this, new GameWonEventArgs(winner));
            }
        }

        private void SetGameBoardToDefaultValues()
        {
            for (var row = 0; row < this.GameBoard.GetLength(0); row++)
            {
                for (var col = 0; col < this.GameBoard.GetLength(1); col++)
                {
                    this.GameBoard[row, col] = string.Empty;
                }
            }
        }
    }
}