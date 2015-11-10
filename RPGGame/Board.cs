using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Board
    {
        public const int EMPTY = 0;
        public const int TREE = 1;
        public const int WALL = 2;
        public const int START = 3;
        public const int END = 4;
        private int[,] board;


        public Board()
        {
            board = new int[,] {
                { 2,2,2,2,2,2,2,2,2,2,2,2 },
                { 2,3,1,0,0,0,0,0,0,0,0,2 },
                { 2,0,1,0,1,1,1,1,0,1,0,2 },
                { 2,0,1,0,1,0,0,1,0,1,0,2 },
                { 2,0,1,0,1,0,0,0,0,1,0,2 },
                { 2,0,1,0,1,0,0,1,0,1,0,2 },
                { 2,0,1,0,1,1,1,1,0,1,0,2 },
                { 2,0,0,0,0,0,0,1,0,1,0,2 },
                { 2,1,1,1,1,1,0,1,0,1,0,2 },
                { 2,0,0,0,0,0,0,1,0,1,0,2 },
                { 2,0,1,0,1,1,1,1,0,1,0,2 },
                { 2,0,0,0,0,0,0,0,0,1,4,2 },
                { 2,2,2,2,2,2,2,2,2,2,2,2 }
            };
        }

        public int GetWidth()
        {
            return 12;
        }

        public int GetHeight()
        {
            return 13;
        }

        public Location GetStartPoint()
        {
            return new Location( 1, 1 );
        }

        public int At(Location l)
        {
            return board[l.Y, l.X];
        }

        public int[,] GetBoard()
        {
            return board;
        }

        public bool IsMovableTo(Location l)
        {
            if (l.X < 0 && l.X > GetWidth() - 1 && l.Y < 0 && l.Y > GetHeight() - 1) return false;
            return (IsEmpty(l) ||  IsEnded(l));
        }

        public bool IsEnded(Location l)
        {
            return At(l) == END;
        }

        public bool IsEmpty(Location l)
        {
            return At(l) == EMPTY;
        }
    }
}
