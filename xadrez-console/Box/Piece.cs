namespace Box
{
    public class Piece
    {
        public Position Position { get; set; }

        public Color Color { get; set; }

        public int MovesCount { get; protected set; }

        public Board Board { get; protected set; }

        public const int MovesCountDefault = 0;

        public Piece (Board board, Color color)
        {
            this.Position = null;
            this.Color = color;
            this.Board = board;

            this.MovesCount = MovesCountDefault;
        }
    }
}
