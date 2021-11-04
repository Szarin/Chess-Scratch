using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Queen : Piece
    {
        public Queen(Player player)
        {
            if (player == Player.Black) {
                Position = new Coordinate(3, 0);
                PlayerColor = Player.Black;
            }
            if (player == Player.White) {
                Position = new Coordinate(3, 7);
                PlayerColor = Player.White;
            }
            id = 'q';
        }

        public override bool IsPossibleMove(int x, int y)
        {
            int initialX = Position.X;
            int initialY = Position.Y;

            return MovementsKit.LShapeMove(initialX, initialY, x, y) || MovementsKit.CrossMove(initialX, initialY, x, y);
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
