using System;

namespace TicTacToe
{
    public class GameConsoled
    {
        public static void Main(string[] args)
        {
            var startBoard = "...\n" +
                             "...\n" +
                             "...";
            Console.WriteLine("Welcome to Tic Tac Toe!" + startBoard);

            while (true)
            {
                var computerTransformedGameBoard = ComputerTurn(startBoard);
                Console.Clear();
                Console.WriteLine(computerTransformedGameBoard + '\n' + "Please input a letter and coordinates: eg. X row,col");

                var humanComputerTransformedBoard = HumanTurn(computerTransformedGameBoard);
                Console.Clear();
                Console.WriteLine(humanComputerTransformedBoard);

                startBoard = NewBoard(humanComputerTransformedBoard);
            }
        }
        // extract
        // interface for human/computer player
        private static string ComputerTurn(string startBoard)
        {
            string resultedComputerTransformedGameBoard;
            var getComputerInputBoard = new ComputerInput();
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
                var getHumanInputBoard = new Game();
                humanComputerTransformedBoard = getHumanInputBoard.TransformingBoard(letter, coord, computerTransformedGameBoard);
            } while (humanComputerTransformedBoard == computerTransformedGameBoard);
            return humanComputerTransformedBoard;
        }

        private static string NewBoard(string checkBoardForWin)
        {
            const string startBoard = "...\n" +
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