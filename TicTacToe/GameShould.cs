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
                  "2,1",

                  "...\n" +
                  "X..\n" +
                  "...")]

        [TestCase("...\n" +
                  "...\n" +
                  "...",
                  "O",
                  "2,2",

                  "...\n" +
                  ".O.\n" +
                  "...")]

//        [TestCase("...\n" +
//                  ".O.\n" +
//                  "...",
//                  "X",
//                  "2,2",
//
//                "Oh no, a piece is already at this place! Try again...")]


        public void ShouldReturnOutputBoard(string inputBoard, string letter, string coord, string outputBoard)
        {
            var game = new Game();
            var result = game.ReturnOutputBoard(letter, coord, inputBoard);
            Assert.AreEqual(outputBoard, result);
        }
    }
}
