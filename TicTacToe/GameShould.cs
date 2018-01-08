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

        [TestCase("...\n" +
                  "...\n" +
                  "...",
                  "X",
                  "2,2",

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
}
