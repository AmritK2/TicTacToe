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
           // string outputBoard = "";
            Console.WriteLine("Welcome to Tic Tac Toe!\n" + startBoard + '\n'+  "Please input a letter and coordinates: eg. X row,col");
            while (true)
            {
                string userInput = Console.ReadLine();
                var input = userInput.Split(' ');
                var letter = input[0];
                var coord = input[1];

                Game getBoard = new Game();
                var resultedBoard = getBoard.ReturnOutputBoard(letter, coord, startBoard);

                Console.Clear();
                Console.WriteLine(resultedBoard);
                startBoard = resultedBoard;
            }
            
        }
    }
}
