using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Board
    {
        public Cell Cells { get; set; }
        private static Board board;

        private Board(int Length, int Width)
        {
            Cells = new int[Length, Width];
        }

        public Board GetBoard(int length, int width)
        {
            if(board == null)
            {
                board = new Board(length, width);
            }
            return board;
        }
    }
}