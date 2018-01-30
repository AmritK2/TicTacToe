namespace TicTacToe
{
    public class Game
    {
        public string TransformingBoard(string letter, string coord, string inputBoard)
        {
            if (letter == "q")
            {
                return "You gave up :(";
            }

            var resultedBoard = string.Empty;
            var position = coord.Split(',');
            var arrayGameBoard = inputBoard.Split('\n');
            for (var row = 0; row < arrayGameBoard.Length; row++)
            {
                for (var column = 0; column < arrayGameBoard.Length; column++)
                {
                    if (row == int.Parse(position[0]) - 1 && column == int.Parse(position[1]) - 1)
                    {
                        resultedBoard = ConvertedBoardUsingInput(letter, resultedBoard, arrayGameBoard, row, column);
                    }
                    else
                    {
                        resultedBoard += arrayGameBoard[row][column];
                    }
                }
                resultedBoard += "\n";
            }
            return ReturnedBoardForNextPlayer(letter, resultedBoard, position, arrayGameBoard);
        }

        private static string ConvertedBoardUsingInput(string letter, string outputBoard, string[] arrayBoard, int row, int column)
        {
            if (arrayBoard[row][column] == '.')
            {
                outputBoard += letter;
            }
            else
            {
                outputBoard += arrayBoard[row][column];
            }
            return outputBoard;
        }

        private string ReturnedBoardForNextPlayer(string letter, string resultedBoard, string[] position, string[] arrayGameBoard)
        {
            var outputBoard = resultedBoard.TrimEnd('\n');
            var isWinner = CheckForWinner(outputBoard, letter, position);

            if (outputBoard.Contains(".")) // !full board? - extrsct tp a finction
            {
                if (isWinner != "")
                {
                    return outputBoard + '\n' + isWinner;
                }
            }
            else if (!outputBoard.Contains("."))
            {
                ResetBoard resetBoard = new ResetBoard();
                return resetBoard.ResettingBoard(arrayGameBoard);
            }
            return outputBoard;
        }

        private string CheckForWinner(string outputBoard, string letter, string[] position)
        {
            var findIfWinner = new CheckingWinner();
            return findIfWinner.CheckWinner(outputBoard, letter, position);
        }
    }
}
