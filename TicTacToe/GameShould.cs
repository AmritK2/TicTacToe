﻿using System;
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

                 "...\n" +
                 "...\n" +
                 "...")]

        [TestCase("X.O\n" +
                  "XO.\n" +
                  "...",
                  "X",
                  "3,1",

                  "X.O\n" +
                  "XO.\n" +
                  "X..\n" +
                  "You've won the game!")]

        [TestCase("XX.\n" +
                  ".O.\n" +
                  ".O.",
                  "X",
                  "1,3",

                  "XXX\n" +
                  ".O.\n" +
                  ".O.\n" +
                  "You've won the game!")]

        [TestCase("OX.\n" +
                  ".X.\n" +
                  "O..",
                  "X",
                  "3,2",

                  "OX.\n" +
                  ".X.\n" +
                  "OX.\n" +
                  "You've won the game!")]

        [TestCase("OO.\n" +
                  ".XX\n" +
                  "...",
                  "X",
                  "2,1",

                  "OO.\n" +
                  "XXX\n" +
                  "...\n" +
                  "You've won the game!")]

        [TestCase("O.X\n" +
                  ".XO\n" +
                  "...",
                  "X",
                  "3,1",

                  "O.X\n" +
                  ".XO\n" +
                  "X..\n" +
                  "You've won the game!")]


        [TestCase("X.O\n" +
                  ".XO\n" +
                  "...",
                  "X",
                  "3,3",

                  "X.O\n" +
                  ".XO\n" +
                  "..X\n" +
                  "You've won the game!")]

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
            var result = game.ReturnOutputBoard(letter, coord, inputBoard);
            Assert.AreEqual(outputBoard, result);
        }
    }
}
