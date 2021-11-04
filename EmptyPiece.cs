using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class EmptyPiece : Piece
    {

        public EmptyPiece(int x, int y)
        {
            Position = new Coordinate(x, y);
        }

        public override bool IsPossibleMove(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "EmptyElement : \n" +
                   "    PositionX : " + Position.X + "\n" +
                   "    PositionY : " + Position.Y + "\n";
        }
    }
}
