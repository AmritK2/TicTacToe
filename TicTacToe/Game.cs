using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Api;

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
                    return resultedBoard + '\n' + output; 
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
            for (var row = 0; row < arrayBoard.Length; row++) // rows
            {
                for (var column = 0; column < arrayBoard[0].Length; column++) // columns
                {
                    result = CheckNeighbours(letter, arrayBoard);
                    if (result == 3)
                    {
                        return "You've won the game!";
                    }
                }
            }
            return "";
        }

        public int CheckNeighbours(string letter, string[] arrayBoard)
        {
            var sign = char.Parse(letter);
            var count = 0;

            for (int column = 0; column < arrayBoard[0].Length; column++)
            {
                for (int row = 0; row < arrayBoard.Length; row++)
                {
                    if (arrayBoard[row][column] == sign)
                    {
                        count++;
                    }
                }
                
            }
            return count;
//            for (int col = arrayBoard[0].Length - 1; col >= 0; col--)
//            {
//
//                int row = 0;
//                int j = col;
//                
//                while (j <= arrayBoard[0].Length - 1)
//                {
//                    if (arrayBoard[row++][j++] == sign)
//                    {
//                        count++;
//                    }
//                }
//            }
//            return count;
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
