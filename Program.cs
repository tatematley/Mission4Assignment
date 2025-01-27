
﻿using System.Formats.Tar;
class Program
{
    static void Main(string[] args)
    {
        // Welcome the user 
        Console.WriteLine("Welcome to our Tic-Tac-Toe game!");

        // Create the game board 
        string[,] board =
        {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" },
        };

        // Assign players 
        char currentPlayer = 'X';
        bool gameOver = false;

        gameTools gt = new gameTools();

        // Ask each player for their choice 
        while (!gameOver)
        {
            gt.printBoard(board);

            Console.WriteLine($" Player {currentPlayer}, choose your position 1 - 9: ");
            string choice = Console.ReadLine();

            if (updateBoard(board, choice, currentPlayer))
            {
                if (gt.checkWin(board, currentPlayer))
                {
                    gt.printBoard(board);
                    Console.WriteLine($" Player {currentPlayer} wins! Congratulations!");
                    gameOver = true;
                }
                else if (gt.checkDraw(board))
                {
                    gt.printBoard(board);
                    Console.WriteLine("It's a draw!");
                    gameOver = true;
                }
                else
                {
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
            }
            else
            {
                Console.WriteLine("Invalid move! please try again!");
            }
        }
    }


    static bool updateBoard(string[,] board, string choice, char currentPlayer)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                // check is position is available 
                if (board[i, j] == choice)
                {
                    board[i, j] = currentPlayer.ToString();
                    return true;
                }
            }
        }
        return false;
    }
}


