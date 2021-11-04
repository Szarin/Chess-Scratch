using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class InitGame
    {
        public static Piece[,] Board { get; private set; }

        public static Pawn[] BlackPawns;
        public static Pawn[] WhitePawns;
        public static Knight[] Knights;
        public static Rook[] Rooks;
        public static Bishop[] Bishops;
        public static King[] Kings;
        public static Queen[] Queens;
        public static List<EmptyPiece> EmptyPieces { get; set; }

        public InitGame()
        {
            Board = new Piece[8, 8];
            InitPawns(Player.White);
            InitPawns(Player.Black);
            InitKnights();
            InitRooks();
            InitBishops();
            InitKings();
            InitQueens();
            InitEmptyPieces();
        }

        private void InitPawns(Player player)
        {
            if (player == Player.Black) {
                BlackPawns = new Pawn[8];
                for (int i = 0; i < 8; i++)
                {
                    BlackPawns[i] = new Pawn(player, i);
                }
            }

            if(player == Player.White)
            {
                WhitePawns = new Pawn[8];
                for (int i = 0; i < 8; i++)
                {
                    WhitePawns[i] = new Pawn(player, i);
                }
            }
        }

        private void InitKnights()
        {
            Knights = new Knight[4];
            Knights[0] = new Knight(Player.Black, 1);
            Knights[1] = new Knight(Player.Black, 6);
            Knights[2] = new Knight(Player.White, 1);
            Knights[3] = new Knight(Player.White, 6);
        }

        private void InitRooks()
        {
            Rooks = new Rook[4];
            Rooks[0] = new Rook(Player.Black, 0);
            Rooks[1] = new Rook(Player.Black, 7);
            Rooks[2] = new Rook(Player.White, 0);
            Rooks[3] = new Rook(Player.White, 7);        
        }

        private void InitBishops()
        {
            Bishops = new Bishop[4];
            Bishops[0] = new Bishop(Player.Black, 2);
            Bishops[1] = new Bishop(Player.Black, 5);
            Bishops[2] = new Bishop(Player.White, 2);
            Bishops[3] = new Bishop(Player.White, 5);
        }

        private void InitKings()
        {
            Kings = new King[2];
            Kings[0] = new King(Player.Black);
            Kings[1] = new King(Player.White);
        }

        private void InitQueens()
        {
            Queens = new Queen[2];
            Queens[0] = new Queen(Player.Black);
            Queens[1] = new Queen(Player.White);
        }

        private void InitEmptyPieces()
        {
            EmptyPieces = new List<EmptyPiece>();
            for(int x = 0; x < 8; x++)
            {
                for(int y = 2; y < 4 + 2; y++) 
                {
                    EmptyPieces.Add(new EmptyPiece(x, y));
                }
            }

            EmptyPieces = EmptyPieces.OrderBy(x => x.Position.Y).ToList();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var element in Board)
            {
                stringBuilder.Append($"Piece : {element.GetType().Name}, X : {element.Position.X}, Y : {element.Position.Y} \n");
            }
            return stringBuilder.ToString();
        }

        public void UpdateBoard()
        {
            InitBoardForEach(EmptyPieces);
            InitBoardForEach(BlackPawns);
            InitBoardForEach(WhitePawns);
            InitBoardForEach(Kings);
            InitBoardForEach(Rooks);
            InitBoardForEach(Queens);
            InitBoardForEach(Bishops);
            InitBoardForEach(Knights);
        }

        // rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR
        private void LoadFen(string fen)
        {
            string[] tabFen = fen.Split("/"); 
            for(int i = 0; i < tabFen.Length; i++)
            {
                foreach(var character in tabFen[i])
                {

                }
            }
        }

        private void InitBoardForEach(List<EmptyPiece> pieces)
        {
            foreach(var element in pieces)
                Board[element.Position.Y, element.Position.X] = element;
        }

        private void InitBoardForEach(Piece[] pieces)
        {
            foreach(var element in pieces)
                Board[element.Position.Y, element.Position.X] = element;
        }

    }
}
