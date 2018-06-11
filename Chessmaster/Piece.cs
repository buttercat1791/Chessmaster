using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessmaster
{
    class Piece
    {
        public PieceValue value;
        public Square location;

        /**
         * Constructor
         * Initializes Piece value and location with input given at instantiation.
         */
        public Piece(PieceValue val, Square loc)
        {
            value = val;
            location = loc;
        }

        /**
         * Function: Move
         * Moves piece in a given Direction a given distance (in number of squares).
         * Does not account for rules of piece movement.
         * Child classes must ensure legality of move before calling this function.
         */ 
        public void Move (Direction dir, int dist)
        {
            // Location enum values correspond to square labels on a chessboard.
            // New columns begin at every 8th value, thus A1 = 0 and B1 = 8.
            // Adding 8 moves the piece one columnn to the right.
            // Subtracting 8 moves the piece one column to the left.
            // Adding or subtracting one moves the piece one square up or down, respectively.
            // Movement is repeated as many times as specified by dist.
            for (int i = 0; i < dist; i++)
            {
                switch (dir)
                {
                    case Direction.Up:
                        location++;
                        break;
                    case Direction.UpRight:
                        location += 9;
                        break;
                    case Direction.Right:
                        location += 8;
                        break;
                    case Direction.DownRight:
                        location += 7;
                        break;
                    case Direction.Down:
                        location--;
                        break;
                    case Direction.DownLeft:
                        location -= 9;
                        break;
                    case Direction.Left:
                        location -= 8;
                        break;
                    case Direction.UpLeft:
                        location -= 7;
                        break;
                }

                Resolve()
            }
        }

        /**
         * Checks final position of Piece.
         * If opposing Piece is at final position, take opposing Piece off board.
         * Once again, child classes must contain rules ensuring the move was legal.
         */
        public void Resolve (Piece target)
        {

        }
    }
}
