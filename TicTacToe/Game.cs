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

            var outputBoard = string.Empty;
                var position = coord.Split(',');
                var arrayBoard = inputBoard.Split('\n');
                for (var row = 0; row < arrayBoard.Length; row++)
                {
                    for (var column = 0; column < arrayBoard.Length; column++)
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
                var findWinner = new CheckingWinner();
                var output = findWinner.CheckWinner(resultedBoard, letter, position);
                if (resultedBoard.Contains("."))
                {
                    if (output != "")
                    {
                        return resultedBoard + '\n' + output;
                    }
                }
                else if (!resultedBoard.Contains(".") && output == "")
                {
                    ResetBoard resetBoard = new ResetBoard();
                    var result = resetBoard.ResettingBoard(arrayBoard);
                    return result;
                }
                return outputBoard.TrimEnd('\n');
            }
    }
}
