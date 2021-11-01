using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Box;

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
                    Position pos = new Position(row, column);
                    Piece piece = board.GetPiece(pos);

                    if (piece == null)
                    {
                        Console.Write(EmptyPosition);
                    }
                    else
                    {
                        Console.Write(piece);
                    }  
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
