using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace xadrez_console
{
    public class Screen
    {
        public const string EmptyPosition = "- ";

        public static void PrintBoard(Board board)
        {
            for (int row = 0; row < board.NumberOfRows; row++)
            {
                for (int column = 0; column < board.NumberOfColumns; column++)
                {
                    Piece piece = board.GetPiece(row, column);

                    if (piece == null)
                    {
                        Console.WriteLine(EmptyPosition);
                    }
                    else
                    {
                        Console.WriteLine(piece);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
