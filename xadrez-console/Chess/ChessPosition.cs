namespace Chess
{
    using Box;

    public class ChessPosition
    {
        public const int RowOffset = 8;

        public const char ColumnOffset = 'a';

        public char Column { get; set; }

        public int Row { get; set; }

        public ChessPosition(char column, int row)
        {
            this.Column = column;
            this.Row = row;
        }
        
        public Position ParseToPosition()
        {
            string columnString = (this.Column - ColumnOffset).ToString();

            if (int.TryParse(columnString, out int column))
            {
                int row = RowOffset - this.Row;

                return new Position(row, column);
            }

            throw new ChessPositionException("Impossible to parse the position.");
        }

        public override string ToString()
        {
            return "" + this.Column + this.Row;
        }
    }
}
