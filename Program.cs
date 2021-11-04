using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            InitGame initGame = new();
            initGame.UpdateBoard();
            Console.WriteLine(initGame.ToString());
            InitGame.Bishops[1].Move(5, 1);
            initGame.UpdateBoard();
            Console.WriteLine(initGame.ToString());
        }
    }
}
