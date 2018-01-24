using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TicTacToe
{
    public class Game
    {
        public string ReturnOutputBoard(string letter, string coord, string inputBoard)
        {
            if (letter == "q")
            {
                return "You gave up :(";
            }

            var resultedBoard = string.Empty;
            var position = coord.Split(',');
            var arrayBoard = inputBoard.Split('\n');
            for (var row = 0; row < arrayBoard.Length; row++)
            {
                for (var column = 0; column < arrayBoard.Length; column++)
                {
                    if (row == int.Parse(position[0]) - 1 && column == int.Parse(position[1]) - 1)
                    {
                        resultedBoard = ConvertedBoardFromUserInput(letter, resultedBoard, arrayBoard, row, column);
                    }
                    else
                    {
                        resultedBoard += arrayBoard[row][column]; 
                    }
                }
                resultedBoard += "\n";
            }

            var outputBoard = resultedBoard.TrimEnd('\n');
            var isWinner = CheckForWinner(outputBoard, letter, position);
            
            if (outputBoard.Contains("."))
            {
                if (isWinner != "")
                {
                    return outputBoard + '\n' + isWinner;
                }
            }
            else if (!outputBoard.Contains("."))
            {
                ResetBoard resetBoard = new ResetBoard();
                return outputBoard = resetBoard.ResettingBoard(arrayBoard);
            }
            return outputBoard;
        }

        private string CheckForWinner(string outputBoard, string letter, string[] position)
        {
            var findWinner = new CheckingWinner();
            return findWinner.CheckWinner(outputBoard, letter, position);
        }

        private static string ConvertedBoardFromUserInput(string letter, string outputBoard, string[] arrayBoard, int row, int column)
        {
            if (arrayBoard[row][column] == '.')
            {
                outputBoard += letter;
            }
            else
            {
                Console.WriteLine("You can only choose a place which is not already taken. Try Again.");
                outputBoard += arrayBoard[row][column];
            }

            return outputBoard;
        }
    }
}
