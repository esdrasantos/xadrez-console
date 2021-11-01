using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Box;
using Chess;

namespace xadrez_console
{
    public class Screen
    {
        public const string EmptyPosition = "- ";

        public static void PrintBoard(Board board)
        {
            for (int row = 0; row < board.NumberOfRows; row++)
            {
                Console.Write(ChessPosition.RowOffset - row + " ");

                for (int column = 0; column < board.NumberOfColumns; column++)
                {
                    Position pos = new Position(row, column);
                    Piece piece = board.GetPiece(pos);

                    if (piece == null)
                    {
                        Console.Write(EmptyPosition);
                    }
                    else
                    {
                        PrintPiece(piece);
                    }
                }

                Console.WriteLine();
            }

            Console.Write(" ");

            for (int column = 0; column < board.NumberOfColumns; column++)
            {
                char charColumn = Convert.ToChar(ChessPosition.ColumnOffset + column);

                Console.Write(" " + charColumn);
            }

            Console.WriteLine();
        }

        public static void PrintPiece(Piece piece)
        {
            ConsoleColor standardForeground = Console.ForegroundColor;

            if (piece.Color == Color.Black)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }

            Console.Write(piece);
            Console.ForegroundColor = standardForeground;
        }
    }
}
