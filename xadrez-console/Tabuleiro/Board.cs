using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    public class Board
    {
        public int NumberOfRows { get; set; }

        public int NumberOfColumns { get; set; }

        public Piece[,] pieces { get; set; }

        public Board(int numberOfRows, int numberOfColumns)
        {
            this.NumberOfRows = numberOfRows;
            this.NumberOfColumns = NumberOfColumns;
            this.pieces = new Piece[numberOfRows, NumberOfColumns];
        }
    }
}
