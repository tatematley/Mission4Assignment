using Mission4;
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
        string choice = "";

        gameTools gt = new gameTools();

        // Ask each player for their choice 
        // Loop continues until the game is over
        while (!gameOver)
        {
            gt.PrintBoard(board); // Display the current game board

            // Prompt the current player to choose a position
            Console.WriteLine($" Player {currentPlayer}, choose your position 1 - 9: ");
            choice = Console.ReadLine(); // Read the player's choice

            // Attempt to update the board with the player's choice
            if (updateBoard(board, choice, currentPlayer))
            {
                // Check if the current player has won
                if (gt.CheckWin(board))
                {
                    gt.PrintBoard(board); // Display final board
                    Console.WriteLine($" Player {currentPlayer} wins! Congratulations!");
                    gameOver = true; // End the game
                }
                // Check if the game is a draw (no more moves available)
                else if (gt.CheckDraw(board))
                {
                    gt.PrintBoard(board); // Display final board
                    Console.WriteLine("It's a draw!");
                    gameOver = true; // End the game
                }
                else
                {
                    // Switch to the other player for the next turn
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
            }
            else
            {
                // Notify the player of an invalid move and allow them to try again
                Console.WriteLine("Invalid move! Please try again!");
            }
        }
    }

    // Function to update the board with the player's choice
    static bool updateBoard(string[,] board, string choice, char currentPlayer)
    {
        // Iterate through the board to find the chosen position
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                // Check if the selected position matches the player's choice
                if (board[i, j] == choice)
                {
                    board[i, j] = currentPlayer.ToString(); // Mark the board with the player's symbol
                    return true; // Move was successful
                }
            }
        }
        return false; // Move was invalid (position already taken or out of range)
    }

    }


