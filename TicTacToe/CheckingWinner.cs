using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal.Commands;

namespace TicTacToe
{
    public class CheckingWinner
    {
        
        public string CheckWinner(string resultedBoard, string letter, string[] position)
        {
            var arrayBoard = resultedBoard.Split('\n');
            for (var row = 0; row < arrayBoard.Length; row++) // rows
            {
                for (var column = 0; column < arrayBoard[0].Length; column++) // columns
                {
                    var winningLines = new WinningLines(); //move to constructor- 
                    //same names
                    var hasWon = winningLines.CheckNeighbours(letter, arrayBoard, position);
                    if (hasWon)
                    {
                        return "You've won the game!";
                    }
                }
            }
            return "";

        }
    }
}
