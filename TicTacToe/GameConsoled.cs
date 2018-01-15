using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.WriteLine("Welcome to Tic Tac Toe!\n" + startBoard + "Please input a letter and coordinates: eg. X row,col");
            string userInput = Console.ReadLine();
            var input = userInput.Split(' ');
            var letter = input[0];
            var coord = input[1];

            Game getBoard = new Game();
            var outputBoard = getBoard.ReturnOutputBoard(letter, coord, startBoard);

            Console.WriteLine(outputBoard);
        }
    }
}
