using System;

namespace Chess
{
    public class ChessPositionException : Exception
    {
        public ChessPositionException(string message) : base(message)
        {

        }
    }
}
