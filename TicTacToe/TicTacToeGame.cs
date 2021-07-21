using System;


namespace TicTacToe
{
    class TicTacToeGame
    {
        public void GameBoard()
        {
            char[] board = new char[10];

            for (int i = 0; i < board.Length; i++)
            {
                board[i] = '_';
                Console.WriteLine(board[i]);
            }
        }
    }
}
