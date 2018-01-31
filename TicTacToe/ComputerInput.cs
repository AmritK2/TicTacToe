using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class ComputerInput
    {
        public string ComputerPlayerInput(string startBoard)
        {
            const string letter = "X";

            var possiblePositions =
                new List<string> {"1,1", "1,2", "1,3", "2,1", "2,2", "2,3", "3,1", "3,2", "3,3"};

            var r = new Random();
            var randomlySelectedIndex = r.Next(possiblePositions.Count);
            var randomlySelectedCoord = possiblePositions[randomlySelectedIndex];

            var getBoardAfterComputerPlayer = new Game();
            var resultedBoard = getBoardAfterComputerPlayer.TransformingBoard(letter, randomlySelectedCoord, startBoard);

            if (!resultedBoard.Contains("won")) return resultedBoard;
            const string resetBoard = "...\n" +
                                      "...\n" +
                                      "...";
            return resetBoard;
        }
    }
}