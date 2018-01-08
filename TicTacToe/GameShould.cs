using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TicTacToe
{
    [TestFixture]
    public class GameShould
    {
        [TestCase( "...\n" +
                   "...\n" +
                   "...", 
                   "X", 
                   "1,1",
                   
                   "X..\n" +
                   "...\n" +
                   "...")]

        [TestCase("...\n" +
                  "...\n" +
                  "...",
                  "X",
                  "1,2",

                  ".X.\n" +
                  "...\n" +
                  "...")]

        public void ShouldReturnOutputBoard(string inputBoard, string letter, string coord, string outputBoard)
        {
            var game = new Game();
            var result = game.ReturnOutputBoard(letter, coord, inputBoard);
            Assert.AreEqual(outputBoard, result);
        }
    }

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
                        outputBoard += letter;
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
