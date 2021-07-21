using System;

namespace TicTacToe
{
    class Program
    {
        public static char[] board { get; private set; }

        static void Main()
        {
            Console.WriteLine("<--------Welcome to Tic Tac Toe Game-------->");
            Console.WriteLine("---------------------------------------------");
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.GameBoard();
            ticTacToeGame.ChooseXorO();
            ticTacToeGame.ShowBoard(ticTacToeGame.board);
        }
    }
}
