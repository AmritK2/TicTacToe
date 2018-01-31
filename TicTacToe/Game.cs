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

            var boardAfterPlayerInput = string.Empty;
            var position = coord.Split(',');
            var arrayGameBoard = inputBoard.Split('\n');
            for (var row = 0; row < arrayGameBoard.Length; row++)
            {
                for (var column = 0; column < arrayGameBoard.Length; column++)
                {
                    if (row == int.Parse(position[0]) - 1 && column == int.Parse(position[1]) - 1)
                    {
                        boardAfterPlayerInput = AddingPlayerInputToTheBoard(letter, boardAfterPlayerInput, arrayGameBoard, row, column);
                    }
                    else
                    {
                        boardAfterPlayerInput += arrayGameBoard[row][column];
                    }
                }
                boardAfterPlayerInput += "\n";
            }
            return ReturnedBoardForNextPlayer(letter, boardAfterPlayerInput, position, arrayGameBoard);
        }

        private static string AddingPlayerInputToTheBoard(string letter, string boardAfterPlayerInput, string[] arrayBoard, int row, int column)
        {
            if (arrayBoard[row][column] == '.')
            {
                boardAfterPlayerInput += letter;
            }
            else
            {
                boardAfterPlayerInput += arrayBoard[row][column];
            }
            return boardAfterPlayerInput;
        }

        private static string ReturnedBoardForNextPlayer(string letter, string boardAfterPlayerInput, string[] position, string[] arrayGameBoard)
        {
            var outputBoard = boardAfterPlayerInput.TrimEnd('\n');
            var boardFull = !outputBoard.Contains(".");

            if (!boardFull) // !full board? - extrsct tp a finction
            {
                var isWinner = CheckForWinner(outputBoard, letter, position);
                if (isWinner != "")
                {
                    return outputBoard + '\n' + isWinner;
                }
            }
            else
            {
                var resetBoard = new ResetBoard();
                return resetBoard.ResettingBoard(arrayGameBoard);
            }
            return outputBoard;
        }

        private static string CheckForWinner(string outputBoard, string letter, string[] position)
        {
            var checkingWinner = new CheckingWinner();
            return checkingWinner.CheckWinner(outputBoard, letter, position);
        }
    }
}