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

            // need x's and o's => always alternate; O will always start
            // need a game board => 3x3
            // need players => at most 2

            int[] board_row1 = new int[3] { 0, 0, 0 };
            int[] board_row2 = new int[3] { 0, 0, 0 };
            int[] board_row3 = new int[3] { 0, 0, 0 };


            _printBoard();

            Console.ReadLine();
        }

        private static int[] _makeAMove(int[] currentRow, int targetColumn, int valueOfColumn)
        {
            currentRow[targetColumn] = valueOfColumn;
            return currentRow;
        }

        private static void _printBoard()
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine("------------");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("------------");
            Console.WriteLine("   |   |   ");
        }
    }
}
