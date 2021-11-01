using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Box;
using Chess;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);
            try
            {
                ChessPosition chessPosition = new ChessPosition('a', 1);

                Console.WriteLine(chessPosition);
                Console.WriteLine(chessPosition.ParseToPosition());

                Piece king = new King(board, Color.Black);
                board.PlacePiece(king, new Position(0, 0));
                Screen.PrintBoard(board);

            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

