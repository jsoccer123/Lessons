using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0
{
    class Program
    {
        static void Main(string[] args)
        {
            // TicTacToe

            // board split between 3 rows
            // each row has 3 columns
            char[] board_row1 = new char[3];
            char[] board_row2 = new char[3];
            char[] board_row3 = new char[3];

            int numberOfMoves = 0;
            string currentPlayer = "0";

            while (numberOfMoves < 10)
            {
                currentPlayer = (numberOfMoves % 2 == 0) ? "O" : "X";
                Console.Write(string.Format("Player1 ({0}) [row, column]: ", currentPlayer));
                
                // input is 'row', 'column'
                string input = Console.ReadLine();
                var inputs = input.Split(new char[] { ',' });

                int row = Int32.Parse(inputs[0]);
                int column = Int32.Parse(inputs[1]);

                switch (row)
                {
                    case 0:
                        board_row1 = _makeAMove(board_row1, column, currentPlayer[0]);
                        break;
                    case 1:
                        board_row2 = _makeAMove(board_row2, column, currentPlayer[0]);
                        break;
                    case 2:
                        board_row3 = _makeAMove(board_row3, column, currentPlayer[0]);
                        break;
                    default:
                        _printError("Invalid Row!");
                        break;
                }

                _printBoard(board_row1, board_row2, board_row3);
                numberOfMoves++;

            }

                Console.ReadLine();
        }

        private static char[] _makeAMove(char[] currentRow, int targetColumn, char valueOfColumn)
        {
            if (currentRow[targetColumn] == 'X' || currentRow[targetColumn] == 'O')
            {
                _printError("Illegal move!"); 
                return currentRow;
            }
            currentRow[targetColumn] = valueOfColumn;
            return currentRow;
        }

        private static void _printBoard(char[] firstRow, char[] secondRow, char[] thirdRow)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", firstRow[0], firstRow[1], firstRow[2]));
            Console.WriteLine("------------");
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", secondRow[0], secondRow[1], secondRow[2]));
            Console.WriteLine("------------");
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", thirdRow[0], thirdRow[1], thirdRow[2]));
        }
        private static void _printError(string errorMessage)
        {
            Console.WriteLine(string.Format("ERROR: {0}", errorMessage));
        }
    }
}
