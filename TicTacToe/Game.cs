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
            var output = CheckWinner(resultedBoard, letter, position);

            if (output != "")
            {
                return resultedBoard + '\n' + output; 
            }
            return outputBoard.TrimEnd('\n');
        }


        public string CheckWinner(string resultedBoard, string letter, string[] position)
        {
           
            var arrayBoard = resultedBoard.Split('\n');
            for (var row = 0; row < arrayBoard.Length; row++) // rows
            {
                for (var column = 0; column < arrayBoard[0].Length; column++) // columns
                {
                    var hasWon = CheckNeighbours(letter, arrayBoard, position);
                    if (hasWon)
                    {
                        return "You've won the game!";
                    }
                }
            }
            return "";
        }

        private List<List<Point>> WinningLines = new List<List<Point>>
        {
            new List<Point> { new Point(0, 0), new Point(0, 1), new Point(0, 2)},
            new List<Point>
            {
                new Point(1, 0),
                new Point(1, 1),
                new Point(1, 2)
            },
            new List<Point>
            {
                new Point(2, 0),
                new Point(2, 1),
                new Point(2, 2)
            },
            new List<Point>
            {
                new Point(0, 0),
                new Point(1, 0),
                new Point(2, 0)
            },
            new List<Point>
            {
                new Point(0, 1),
                new Point(1, 1),
                new Point(2, 1)
            },
            new List<Point>
            {
                new Point(0, 2),
                new Point(1, 2),
                new Point(2, 2)
            },
            new List<Point>
            {
                new Point(0, 0),
                new Point(1, 1),
                new Point(2, 2)
            },
            new List<Point>
            {
                new Point(0, 2),
                new Point(1, 1),
                new Point(2, 0)
            }
        };
        

        public bool CheckNeighbours(string letter, string[] arrayBoard, string[] position)
        {
            var sign = char.Parse(letter);

            return WinningLines.Any(winningLine => winningLine.All(point => arrayBoard[point.Row][point.Column] == sign));
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

    public class Point
    {
        public Point(int row, int column)
        {
            Row = row;
            Column = column;
        }
        public int Row { get; set; }
        public int Column { get; set; }

    }
}
