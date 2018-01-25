using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class ComputerInput
    {
        public string ComputerResultedBoard(string startBoard)
        {
            string letter = "X";

            List<string> possiblePositions =
                new List<string> {"1,1", "1,2", "1,3", "2,1", "2,2", "2,3", "3,1", "3,2", "3,3"};

            Random r = new Random();
            int index = r.Next(possiblePositions.Count);
            string chosenPosition = possiblePositions[index];

            Game getPersonBoard = new Game();
            string resultedBoard = getPersonBoard.ReturnOutputBoard(letter, chosenPosition, startBoard);

            if (resultedBoard.Contains("won"))
            {
                string resetBoard = "...\n" +
                                    "...\n" +
                                    "...";
                return resetBoard;
            }
            return resultedBoard;
        }
    }
}