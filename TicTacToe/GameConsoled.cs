﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameConsoled
    {
        static void Main(string[] args)
        {
            var changedBoard = "";
            string startBoard = "...\n" +
                                "...\n" +
                                "...";
            Console.WriteLine("Welcome to Tic Tac Toe!" + startBoard);

            while (true)
            {
                ComputerInput computerInputReturnedBoard = new ComputerInput();
                do
                {
                    changedBoard = computerInputReturnedBoard.ComputerResultedBoard(startBoard);
                } while (changedBoard == startBoard);

                    Console.Clear();
                Console.WriteLine(changedBoard + '\n' +  "Please input a letter and coordinates: eg. X row,col");

                string userInput = Console.ReadLine();
                var input = userInput.Split(' ');
                var letter = input[0];
                var coord = input[1];

                Game getBoard = new Game();
                var resultedBoard = getBoard.ReturnOutputBoard(letter, coord, changedBoard);

                Console.Clear();
                Console.WriteLine(resultedBoard);

                if (!resultedBoard.Contains("won"))
                {
                    startBoard = resultedBoard;
                }

                else
                {
                    var resultedArrayBoard = resultedBoard.Split('\n');
                    ResetBoard newBoard = new ResetBoard();
                    var result = newBoard.ResettingBoard(resultedArrayBoard);
                    startBoard =  resultedBoard;
                }
            }
        }
    }
}
