using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Box;

namespace xadrez_console
{
    public class King : Piece
    {
        public const string PieceName = "K ";

        public King(Board board, Color color) : base (board, color)
        {
        }

        public override string ToString()
        {
            return PieceName;
        }
    }
}
