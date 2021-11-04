using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public enum Player { Black, White }

    abstract class Piece
    {
        public Coordinate Position { get; set; }
        public char id { get; init; }
        public Player PlayerColor { get; init; }

        public void Move(int x, int y)
        {
            if (IsPossibleMove(x, y))
            {
                InitGame.EmptyPieces.Add(new EmptyPiece(Position.X, Position.Y));

                Position.X = x;
                Position.Y = y;
                return;
            }
            Console.WriteLine("Erreur : Mouvement impossible.");
        }

        public abstract bool IsPossibleMove(int x, int y);
        public abstract void Remove();


        
    }
}
