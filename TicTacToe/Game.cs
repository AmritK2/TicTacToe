using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TicTacToe
{
    public class Game
    {
        public string ReturnOutputBoard(string letter, string coord, string inputBoard)
        {
            var outputBoard = string.Empty;
            var position = coord.Split(',');
            var arrayBoard = inputBoard.Split('\n');

            if (letter == "q") // extract
            {
                var result = ResetBoard(arrayBoard);
                return result;
            }
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

            if (output != "")
            {
                return resultedBoard + '\n' + output; 
            }
            return outputBoard.TrimEnd('\n');
        }
        
        private static string ResetBoard(string[] arrayBoard)
        {
            var outputBoard = "";
            const string reset = ".";
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
