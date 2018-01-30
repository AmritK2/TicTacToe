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
        [TestCase("...\n" +
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
            "O",
            "2,2",

            "...\n" +
            ".O.\n" +
            "...")]

        [TestCase("...\n" +
                  "...\n" +
                  ".X.",
            "O",
            "3,2",

            "...\n" +
            "...\n" +
            ".X.")]

        [TestCase("...\n" +
                  "...\n" +
                  ".X.",
            "q",
            "3,2",

            "You gave up :(")]

        [TestCase("X.O\n" +
                  "XO.\n" +
                  "...",
            "X",
            "3,1",

            "X.O\n" +
            "XO.\n" +
            "X..\n" +
            "You've won the game!")]

        [TestCase("OO.\n" +
                  ".XX\n" + // not working
                  "...",
            "X",
            "3,1",

            "OO.\n" +
            ".XX\n" +
            "X..")]

        [TestCase("X.O\n" +
                  ".OX\n" +
                  "...",
            "O",
            "3,1",

            "X.O\n" +
            ".OX\n" +
            "O..\n" +
            "You've won the game!")]

        public void ShouldReturnOutputBoard(string inputBoard, string letter, string coord, string outputBoard)
        {
            var game = new Game();
            var result = game.TransformingBoard(letter, coord, inputBoard);
            Assert.AreEqual(outputBoard, result);
        }
    }
}
