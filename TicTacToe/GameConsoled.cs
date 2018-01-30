using System;
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
            var computerTransformedGameBoard = "";
            var humanComputerTransformedBoard = "";
            string startBoard = "...\n" +
                                "...\n" +
                                "...";
            Console.WriteLine("Welcome to Tic Tac Toe!" + startBoard);

            while (true)
            {
                computerTransformedGameBoard = ComputerTurn(startBoard);
                Console.Clear();
                Console.WriteLine(computerTransformedGameBoard + '\n' + "Please input a letter and coordinates: eg. X row,col");

                humanComputerTransformedBoard = HumanTurn(computerTransformedGameBoard);
                Console.Clear();
                Console.WriteLine(humanComputerTransformedBoard);

                startBoard = NewBoard(humanComputerTransformedBoard);
            }
        }

        private static string ComputerTurn(string startBoard)
        {
            string resultedComputerTransformedGameBoard;
            ComputerInput getComputerInputBoard = new ComputerInput();
            do
            {
                resultedComputerTransformedGameBoard = getComputerInputBoard.ComputerPlayerInput(startBoard);
            } while (resultedComputerTransformedGameBoard == startBoard);
            return resultedComputerTransformedGameBoard;
        }

        private static string HumanTurn(string computerTransformedGameBoard)
        {
            string humanComputerTransformedBoard;
            do
            {
                string humanPlayerInput = Console.ReadLine();
                var input = humanPlayerInput.Split(' ');
                var letter = input[0];
                var coord = input[1];
                Game getHumanInputBoard = new Game();
                humanComputerTransformedBoard = getHumanInputBoard.TransformingBoard(letter, coord, computerTransformedGameBoard);
            } while (humanComputerTransformedBoard == computerTransformedGameBoard);
            return humanComputerTransformedBoard;
        }

        private static string NewBoard(string checkBoardForWin)
        {
            string startBoard = "...\n" +
                                "...\n" +
                                "...";
            if (checkBoardForWin.Contains("won"))
            {
                return startBoard;
            }
            Console.Clear();
            return checkBoardForWin;
        }
    }
}