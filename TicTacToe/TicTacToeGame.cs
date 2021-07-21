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
                board[i] = ' ';
                Console.WriteLine(board[i]);
            }
        }
        public void ChooseXorO()
        {
            Console.Write("Enter X or O : ");
            char UserChoice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(char.ToUpper(UserChoice));
        }
    }
}
