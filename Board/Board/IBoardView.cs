using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    interface IBoardView
    {
        void Paint(Board board);
        void PutFigures(Board board);
    }
}
