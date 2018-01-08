using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        public string ReturnOutputBoard(string letter, string coord, string inputBoard)
        {
            var outputBoard = string.Empty;
            var position = coord.Split(',');
            var arrayBoard = inputBoard.Split('\n');

            if (letter != "q")
            {
                for (var row = 0; row < arrayBoard.Length; row++)
                {
                    for (int column = 0; column < arrayBoard.Length; column++)
                    {
                        if (row == int.Parse(position[0]) - 1 && column == int.Parse(position[1]) - 1)
                        {
                            if (arrayBoard[row][column] == '.')
                            {
                                outputBoard += letter;
                              
                            }
                            else
                            {
                                outputBoard += arrayBoard[row][column];
                            }

                        }
                        else
                        {
                            outputBoard += arrayBoard[row][column];
                        }

                    }
                    outputBoard += "\n";

                }
                var resultedBoard = outputBoard.TrimEnd('\n');
                var output = CheckWinner(resultedBoard, letter);

                if (output != "")
                {
                    return resultedBoard + output; 
                }
                return outputBoard.TrimEnd('\n');
            }
            var result = ResetBoard(arrayBoard);
            return result;
        }
        
        public string CheckWinner(string resultedBoard, string letter)
        {
            var result = 0;
            var arrayBoard = resultedBoard.Split('\n');
            if (result < 3)
            {
                for (var row = 0; row < arrayBoard.Length; row++) // rows
                {
                    for (var column = 0; column < arrayBoard[0].Length; column++) // columns
                    {
                        result = CheckNeighbours(letter, row, column, arrayBoard);
                    }
                }
                return "";
            }
            return "You've won the game!";
        }

        public int CheckNeighbours(string letter, int row, int column, string[] arrayBoard)
        {
            var totalColumns = arrayBoard[0].Length - 1;
            var totalRows = arrayBoard.Length - 1;
            var count = 0;
            var sign = char.Parse(letter);

            var minRows = Math.Max(0, row - 1);
            var maxRows = Math.Min(row + 1, totalRows);
            var minColumns = Math.Max(0, column - 1);
            var maxColumns = Math.Min(column + 1, totalColumns);

            for (int rowCoord = minRows; rowCoord <= maxRows; rowCoord++)
            {
                for (int colCoord = minColumns; colCoord <= maxColumns; colCoord++)
                {
                    if (arrayBoard[rowCoord][colCoord] == sign)
                    {
                        if (rowCoord == row && colCoord == column)
                        {
                            continue;
                        }
                        count++;
                    }

                }
            }
            return count;
        }

        private string ResetBoard(string[] arrayBoard)
        {
            var outputBoard = "";
            var reset = ".";
            for (var row = 0; row < arrayBoard.Length; row++)
            {
                for (int column = 0; column < arrayBoard.Length; column++)
                {
                    outputBoard += reset;
                }
                outputBoard += "\n";
            }
            return outputBoard.TrimEnd('\n');
        }
    }
}
