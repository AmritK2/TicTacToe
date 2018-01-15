using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class ResetBoard
    {
        public string ResettingBoard(string[] arrayBoard)
        {
            var outputBoard = "";
            const string reset = ".";
            for (var row = 0; row < arrayBoard.Length; row++)
            {
                for (var column = 0; column < arrayBoard.Length; column++)
                {
                    outputBoard += reset;
                }
                outputBoard += "\n";
            }
            return outputBoard.TrimEnd('\n');
        }
    }
}
