using System;
using System.Collections.Generic;
using System.Text;


namespace TicTacToe
{
    class TicTacToeGame
    {
        public char[] board = new char[10];
        public void GameBoard()
        {
            
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }
        /// <summary>
        /// method to choose X or O
        /// </summary>
        public void ChooseXorO()
        {
            Console.Write("Enter X or O : ");
            
            char UserChoice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Your letter is :- " + char.ToUpper(UserChoice));
            Console.WriteLine("---------------------------------------------");
        }
        /// <summary>
        /// method to display the board
        /// </summary>
        /// <param name="board"></param>
        public void ShowBoard(char[] board)
        {
            Console.WriteLine("\n" + board[1] + "  | " + board[2] + "  | " + board[3]);
            Console.WriteLine("------------");
            Console.WriteLine(board[4] + "  | " + board[5] + "  | " + board[6]);
            Console.WriteLine("------------");
            Console.WriteLine(board[7] + "  | " + board[8] + "  | " + board[9]);
        }
    }
}
