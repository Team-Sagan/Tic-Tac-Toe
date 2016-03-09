namespace Tic_Tack_Toe.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using Tic_Tack_Toe.Interfaces;

    public class SinglePlayerGameRoomModel : GameBoardModel, ISinglePlayerGameBoardModel
    {
        private const int MaxScore = 3;

        private string[,] board = new string[3, 3];

        private int turnCount = -1;

        public SinglePlayerGameRoomModel(IPlayer firstPlayer, IPlayer secondPlayer)
            : base(firstPlayer, secondPlayer)
        {
        }

        public int[] ComputerMove()
        {
            string[,] gameboard = this.Clone(this.GameBoard);

            int[] move = new int[2];
            int moveResult = int.MinValue;

            int[] winMove = new int[2];
            bool computerWins = false;

            int[] stopPlayerWinMove = new int[2];
            bool stopPlayerWin = false;

            for (int row = 0; row < gameboard.GetLength(0); row++)
            {
                for (int col = 0; col < gameboard.GetLength(1); col++)
                {
                    if (gameboard[row, col] != string.Empty)
                    {
                        continue;
                    }

                    this.board = this.Clone(gameboard);
                    var firstLevelAiResult = this.FirstLevelCheck(row, col, this.SecondPlayer.PlayerSymbol);
                    if (firstLevelAiResult)
                    {
                        winMove[0] = row;
                        winMove[1] = col;
                        computerWins = true;
                    }

                    this.board = this.Clone(gameboard);
                    var firstLevelPlayerResult = this.FirstLevelCheck(row, col, this.FirstPlayer.PlayerSymbol);
                    if (firstLevelPlayerResult)
                    {
                        stopPlayerWinMove[0] = row;
                        stopPlayerWinMove[1] = col;
                        stopPlayerWin = true;
                    }

                    this.board = this.Clone(gameboard);
                    this.turnCount = -1;
                    var currentMoveResult = this.PossibleMoves(row, col);
                    if (moveResult < currentMoveResult)
                    {
                        moveResult = currentMoveResult;
                        move[0] = row;
                        move[1] = col;
                    }
                }
            }

            if (computerWins)
            {
                return winMove;
            }

            if (stopPlayerWin)
            {
                return stopPlayerWinMove;
            }

            return move;
        }

        private string[,] Clone(string[,] ticTackToe)
        {
            string[,] clone = new string[ticTackToe.GetLength(0), ticTackToe.GetLength(1)];

            for (int row = 0; row < ticTackToe.GetLength(0); row++)
            {
                for (int col = 0; col < ticTackToe.GetLength(1); col++)
                {
                    clone[row, col] = ticTackToe[row, col];
                }
            }

            return clone;
        }

        private int MaxResult(
           Dictionary<int, List<string>> checkRows,
           Dictionary<int, List<string>> checkCols,
           List<string> diagonalLeftToRight,
           List<string> diagonalRightToLeft,
           string currentPlayerSymbol)
        {
            int bestResult = 0;
            bestResult = checkRows.Select(row => row.Value.Count(x => x == currentPlayerSymbol)).Concat(new[] { bestResult }).Max();
            bestResult = checkCols.Select(col => col.Value.Count(x => x == currentPlayerSymbol)).Concat(new[] { bestResult }).Max();

            int leftDiagonalResult = diagonalLeftToRight.Count(x => x == currentPlayerSymbol);
            if (leftDiagonalResult > bestResult)
            {
                bestResult = leftDiagonalResult;
            }

            int rightDiagonalResult = diagonalRightToLeft.Count(x => x == currentPlayerSymbol);
            if (rightDiagonalResult > bestResult)
            {
                bestResult = rightDiagonalResult;
            }

            return bestResult;
        }

        private int CheckCurrentMoveResult(string player)
        {
            var checkRows = new Dictionary<int, List<string>>();
            var checkCols = new Dictionary<int, List<string>>();
            List<string> diagonalLeftToRight = new List<string>();
            List<string> diagonalRightToLeft = new List<string>();

            int diagonalCol = 1;
            for (int rowGameboard = 0; rowGameboard < this.board.GetLength(0); rowGameboard++)
            {
                for (int colGameboard = 0; colGameboard < this.board.GetLength(1); colGameboard++)
                {
                    if (!checkRows.ContainsKey(rowGameboard))
                    {
                        checkRows[rowGameboard] = new List<string>();
                    }

                    if (!checkCols.ContainsKey(colGameboard))
                    {
                        checkCols[colGameboard] = new List<string>();
                    }

                    checkRows[rowGameboard].Add(this.board[rowGameboard, colGameboard]);
                    checkCols[colGameboard].Add(this.board[rowGameboard, colGameboard]);
                }

                diagonalLeftToRight.Add(this.board[rowGameboard, diagonalCol - 1]);
                diagonalRightToLeft.Add(this.board[rowGameboard, this.board.GetLength(1) - diagonalCol]);
                diagonalCol++;
            }

            int bestAiResult = this.MaxResult(checkRows, checkCols, diagonalLeftToRight, diagonalRightToLeft, player);

            return bestAiResult;
        }

        private bool FirstLevelCheck(int row, int col, string player)
        {
            this.board[row, col] = player;
            if (this.CheckCurrentMoveResult(player) == MaxScore)
            {
                return true;
            }

            return false;
        }

        private int PossibleMoves(int row, int col)
        {
            this.turnCount++;
            int nextMoveResult = 0;
            string player = this.SecondPlayer.PlayerSymbol;
            if (this.turnCount % 2 != 0)
            {
                player = this.FirstPlayer.PlayerSymbol;
            }

            this.board[row, col] = player;
            var moveResult = this.CheckCurrentMoveResult(player);

            if (moveResult == MaxScore && player == this.SecondPlayer.PlayerSymbol)
            {
                return moveResult;
            }

            if (moveResult == MaxScore && player == this.FirstPlayer.PlayerSymbol)
            {
                return moveResult * -1;
            }

            for (int rowBoard = 0; rowBoard < this.board.GetLength(0); rowBoard++)
            {
                for (int colBoard = 0; colBoard < this.board.GetLength(1); colBoard++)
                {
                    if (this.board[rowBoard, colBoard] != string.Empty)
                    {
                        continue;
                    }

                    nextMoveResult = this.PossibleMoves(rowBoard, colBoard);
                    if (nextMoveResult == MaxScore || nextMoveResult == MaxScore * -1)
                    {
                        break;
                    }
                }

                if (nextMoveResult == MaxScore || nextMoveResult == MaxScore * -1)
                {
                    break;
                }
            }

            if (nextMoveResult != MaxScore && nextMoveResult != MaxScore * -1)
            {
                nextMoveResult = 0;
            }

            return nextMoveResult;
        }
    }
}