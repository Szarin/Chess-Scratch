using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class King : Piece
    {

        public King(Player player)
        {
            if(player == Player.Black) {
                Position = new Coordinate(4, 0);
                PlayerColor = Player.Black;
            }
            if (player == Player.White) {
                Position = new Coordinate(4, 7);
                PlayerColor = Player.White;
            }
            id = 'k';
        }

        public override bool IsPossibleMove(int x, int y)
        {
            return false;
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
