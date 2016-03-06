namespace Tic_Tack_Toe.Character
{
    using System.Collections.Generic;
    using System.Linq;

    using Interfaces;

    using Tic_Tack_Toe.Models;

    /// <summary>
    /// Main logic for artificial intelligence
    /// </summary>
    public class Computer : Player, IArtificialIntelligence
    {
        private const string ComputerName = "Computer";
        private readonly string computerSymbol;
        private readonly string playerSymbol;
        private readonly string emptySpace = string.Empty;
        private readonly int maxScore = 3;
        private string[,] board = new string[3, 3];
        private int turnCount = -1;

        public Computer(string computerSymbol, string playerSymbol)
            : base(ComputerName, playerSymbol)
        {
            this.computerSymbol = computerSymbol;
            this.playerSymbol = playerSymbol;
            this.PlayerSymbol = computerSymbol;
        }
        
        public int[] AiMove(string[,] ticTacToe)
        {
            string[,] gameboard = this.Clone(ticTacToe);

            int[] move = new int[2];
            int moveResult = int.MinValue;
            int currentMoveResult = int.MinValue;
            bool firstLevelAiResult = false;
            bool firstLevelPlayerResult = false;

            for (int row = 0; row < gameboard.GetLength(0); row++)
            {
                for (int col = 0; col < gameboard.GetLength(1); col++)
                {
                    if (gameboard[row, col] != this.emptySpace)
                    {
                        continue;
                    }

                    this.board = this.Clone(gameboard);
                    firstLevelAiResult = this.FirstLevelCheck(row, col, this.computerSymbol);

                    this.board = this.Clone(gameboard);
                    firstLevelPlayerResult = this.FirstLevelCheck(row, col, this.playerSymbol);

                    if (firstLevelAiResult || firstLevelPlayerResult)
                    {
                        move[0] = row;
                        move[1] = col;
                        break;
                    }

                    this.board = this.Clone(gameboard);
                    this.turnCount = -1;
                    currentMoveResult = this.PossibleMoves(row, col);
                    if (moveResult < currentMoveResult)
                    {
                        moveResult = currentMoveResult;
                        move[0] = row;
                        move[1] = col;
                    }
                }

                if (firstLevelAiResult || firstLevelPlayerResult)
                {
                    break;
                }
            }

            return move;
        }

        private bool FirstLevelCheck(int row, int col, string player)
        {
            this.board[row, col] = player;
            if (this.CheckCurrentMoveResult(player) == this.maxScore)
            {
                return true;
            }

            return false;
        }

        private int PossibleMoves(int row, int col)
        {
            this.turnCount++;
            int moveResult = 0;
            int nextMoveResult = 0;
            string player = this.computerSymbol;
            if (this.turnCount % 2 != 0)
            {
                player = this.playerSymbol;
            }

            this.board[row, col] = player;
            moveResult = this.CheckCurrentMoveResult(player);

            if (moveResult == this.maxScore && player == this.computerSymbol)
            {
                return moveResult;
            }

            if (moveResult == this.maxScore && player == this.playerSymbol)
            {
                return moveResult * -1;
            }

            for (int rowBoard = 0; rowBoard < this.board.GetLength(0); rowBoard++)
            {
                for (int colBoard = 0; colBoard < this.board.GetLength(1); colBoard++)
                {
                    if (this.board[rowBoard, colBoard] != this.emptySpace)
                    {
                        continue;
                    }

                    nextMoveResult = this.PossibleMoves(rowBoard, colBoard);
                    if (nextMoveResult == this.maxScore || nextMoveResult == this.maxScore * -1)
                    {
                        break;
                    }
                }

                if (nextMoveResult == this.maxScore || nextMoveResult == this.maxScore * -1)
                {
                    break;
                }
            }

            if (nextMoveResult != this.maxScore && nextMoveResult != this.maxScore * -1)
            {
                nextMoveResult = 0;
            }

            return nextMoveResult;
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
    }
}