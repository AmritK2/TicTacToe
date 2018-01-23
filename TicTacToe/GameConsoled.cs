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
            string startBoard = "...\n" +
                                "...\n" +
                                "...";
            Console.WriteLine("Welcome to Tic Tac Toe!" + startBoard);

            while (!startBoard.Contains("won"))
            {
                ComputerInput computerInputReturnedBoard = new ComputerInput();
                var changedBoard = computerInputReturnedBoard.ComputerResultedBoard(startBoard);
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
                startBoard = resultedBoard;
            }
            
        }
    }
}
