using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public static class MovementsKit
    {
        public static bool DiagonalsMove(int initialX, int initialY, int moveX, int moveY)
        {
            return ComputeMove(initialX, initialY, moveX, moveY, 1, 1) || ComputeMove(initialX, initialY, moveX, moveY, 1, -1) ||
                   ComputeMove(initialX, initialY, moveX, moveY, -1, 1) || ComputeMove(initialX, initialY, moveX, moveY, -1, -1);
        }

        public static bool CrossMove(int initialX, int initialY, int moveX, int moveY)
        {
            return ComputeMove(initialX, initialY, moveX, moveY, 0, -1) || ComputeMove(initialX, initialY, moveX, moveY, 0, 1) ||
                   ComputeMove(initialX, initialY, moveX, moveY, 1, 0) || ComputeMove(initialX, initialY, moveX, moveY, -1, 0);
        }

        public static bool LShapeMove(int initialX, int initialY, int moveX, int moveY)
        {
            return ComputeLShapeMove(initialX, initialY, moveX, moveY, -1, -2) || ComputeLShapeMove(initialX, initialY, moveX, moveY, 1, -2) ||
                   ComputeLShapeMove(initialX, initialY, moveX, moveY, -2, -1) || ComputeLShapeMove(initialX, initialY, moveX, moveY, 2, -1) ||
                   ComputeLShapeMove(initialX, initialY, moveX, moveY, -2, 1) || ComputeLShapeMove(initialX, initialY, moveX, moveY, 2, 1) ||
                   ComputeLShapeMove(initialX, initialY, moveX, moveY, -1, 2) || ComputeLShapeMove(initialX, initialY, moveX, moveY, 1, 2);
        }

        private static bool ComputeLShapeMove(int initialX, int initialY, int moveX, int moveY, int addX, int addY)
        {
            return ((initialX + addX) == moveX && (initialY + addY) == moveY && !isPiece(initialX, initialY)) ? true : false;
        }

        private static bool ComputeMove(int initialX, int initialY, int moveX, int moveY, int incrementX, int incrementY)
        {
            while ((initialX < InitGame.Board.GetLength(1) && initialY < InitGame.Board.GetLength(0)) &&
                    (initialX >= 0 && initialY >= 0) && !isPiece(initialX, initialY))
            {
                initialX += incrementX;
                initialY += incrementY;
                if (moveX == initialX && moveY == initialY)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool isPiece(int x, int y)
        {
            if (InitGame.Board[x - 1, y - 1] is EmptyPiece)
            {
                return true;
            }
            return false;
        }
    }
}
