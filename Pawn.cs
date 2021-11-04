using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pawn : Piece
    {
        public Pawn(Player player, int x)
        {
            if (player == Player.Black) {
                Position = new Coordinate(x, 1);
                PlayerColor = Player.Black;
            }
            if (player == Player.White) {
                Position = new Coordinate(x, 6);
                PlayerColor = Player.White;
            }
            id = 'p';
        }

        public override bool IsPossibleMove(int x, int y)
        {
            int initialX = Position.X;
            int initialY = Position.Y;
            
            if(PlayerColor == Player.Black) 
            {
                if ((initialX + 1 == x && initialY + 1 == y) ||
                   (initialX == x && initialY + 1 == y) ||
                   (initialX - 1 == x && initialY + 1 == y))
                    return true;
            }
            if(PlayerColor == Player.White)
            {
                if ((initialX - 1 == x && initialY - 1 == y) ||
                   (initialX == x && initialY - 1 == y) ||
                   (initialX + 1 == x && initialY - 1 == y))
                    return true;
            }

            return false;
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
