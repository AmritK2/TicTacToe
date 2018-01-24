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
            var changedBoard = "";
            var resultedBoard = "";
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
                Console.WriteLine(changedBoard + '\n' + "Please input a letter and coordinates: eg. X row,col");
                changedBoard = NewBoard(changedBoard);

                do
                {
                    string userInput = Console.ReadLine();
                    var input = userInput.Split(' ');
                    var letter = input[0];
                    var coord = input[1];
                    Game getBoard = new Game();
                    resultedBoard = getBoard.ReturnOutputBoard(letter, coord, changedBoard);
                } while (resultedBoard == changedBoard);

                Console.Clear();
                Console.WriteLine(resultedBoard);
                startBoard = NewBoard(resultedBoard);
            }
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
            return checkBoardForWin;
        }
    }
}