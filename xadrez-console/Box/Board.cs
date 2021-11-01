using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class Board
    {
        public int NumberOfRows { get; set; }

        public int NumberOfColumns { get; set; }

        private Piece[,] _pieces;

        public Board(int numberOfRows, int numberOfColumns)
        {
            this.NumberOfRows = numberOfRows;
            this.NumberOfColumns = numberOfColumns;

            this._pieces = new Piece[numberOfRows, NumberOfColumns];
        }

        public Piece GetPiece(Position pos)
        {
            return this._pieces[pos.Row, pos.Column];
        }

        public void PlacePiece(Piece piece, Position pos)
        {
            if(IsEmptyPosition(pos))
            {
                this._pieces[pos.Row, pos.Column] = piece;
                piece.Position = pos;
            }
            else
            {
                throw new BoardException("Position is not empty.");
            }
        }

        public bool IsEmptyPosition(Position pos)
        {
            this.ValidatePosition(pos);

            return this.GetPiece(pos) == null;
        }

        public bool IsValidPosition(Position pos)
        {
            bool isValidRow = pos.Row >= 0 && pos.Row < NumberOfRows;
            bool isValidColumn = pos.Column >= 0 && pos.Column < NumberOfColumns;

            if (isValidRow && isValidColumn)
            {
                return true;
            }

            return false;
        }

        public void ValidatePosition(Position pos)
        {
            if (IsValidPosition(pos))
            {
            }
            else
            {
                throw new BoardException("Invalid position!");
            }
        }
    }
}
