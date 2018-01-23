using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
   public class WinningLines
    {

        private List<List<Point>> WinningLine = new List<List<Point>>
        {
            new List<Point> { new Point(0, 0), new Point(0, 1), new Point(0, 2)},
            new List<Point> { new Point(1, 0), new Point(1, 1), new Point(1, 2)},
            new List<Point> { new Point(2, 0), new Point(2, 1), new Point(2, 2)},
            new List<Point> { new Point(0, 0), new Point(1, 0), new Point(2, 0)},
            new List<Point> { new Point(0, 1), new Point(1, 1), new Point(2, 1)},
            new List<Point> { new Point(0, 2), new Point(1, 2), new Point(2, 2)},
            new List<Point> { new Point(0, 0), new Point(1, 1), new Point(2, 2)},
            new List<Point> { new Point(0, 2), new Point(1, 1), new Point(2, 0)}
        };

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

        public bool CheckNeighbours(string letter, string[] arrayBoard, string[] position)
        {
            var sign = char.Parse(letter);

            return WinningLine.Any(winningLine => winningLine.All(point => arrayBoard[point.Row][point.Column] == sign));
        }
    }
}
