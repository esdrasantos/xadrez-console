namespace Tabuleiro
{
    public class Piece
    {
        public Position Position { get; set; }

        public Color Color { get; protected set; }

        public int MovesCount { get; protected set; }

        public Board Board { get; protected set; }

        public const int MovesCountDefault = 0;

        public Piece (Position pos, Color color, Board board)
        {
            this.Position = pos;
            this.Color = Color;
            this.Board = board;

            this.MovesCount = MovesCountDefault;
        }
    }
}
