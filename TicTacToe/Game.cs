using System;
using System.Collections.Generic;
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

            return outputBoard.TrimEnd('\n');
        }
    }
}
