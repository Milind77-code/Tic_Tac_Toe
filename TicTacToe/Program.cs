using System;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("<--------Welcome to Tic Tac Toe Game-------->");
            Console.WriteLine("---------------------------------------------");
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.GameBoard();
        }
    }
}
