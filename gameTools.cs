using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//• Receive the “board” array from the driver class
//• Contain a method that prints the board based on the information passed to it
//	- display 3x3 with numbers, X's, & O's
//• Contain a method that receives the game board array as input and returns if there is a winner and who it was
//	- check for a win

namespace Mission4
{
    internal class gameTools
    {
        public void PrintBoard(string[,] gameBoard)
        {
            //Console.WriteLine("PrintBoard called"); //for testing
            // print the numbered spots
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(gameBoard[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public bool CheckWin(string[,] gameBoard)
        {
            //Console.WriteLine("CheckWin called"); //for testing

            // check rows for three in a row
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2])
                {
                    Console.WriteLine("row win");
                    return true;
                }
            }

            // check columns for three in a row
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[0, i] == gameBoard[1, i] && gameBoard[1, i] == gameBoard[2, i])
                {
                    Console.WriteLine("column win");
                    return true;
                }
            }

            // check diagonals for three in a row
            if (gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2])
            {
                Console.WriteLine("diagonal win");
                return true;
            }
            if (gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0])
            {
                Console.WriteLine("diagonal win");
                return true;
            }

            return false;
        }
        
        public bool CheckDraw(string[,] gameBoard)
        {
            // check for a draw 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gameBoard[i, j] != "X" && gameBoard[i, j] != "O")
                    {
                        return false; // if an empty cell is found, return false
                    }
                }
            }

            return true; // no empty cells and no wins
        }
    }
}
