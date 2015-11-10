using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class RPGGameModel : Model
    {
        private Board board;
        private Actor hero;
        private Actor monster;
        private Random random;

        public const int UP = 0;
        public const int DOWN = 1;
        public const int LEFT = 2;
        public const int RIGHT = 3;

        public const int MOVED = 0;
        public const int ENDED = 1;
        public const int MONSTER = 2;
        public const int CANTMOVE = 3;
        public const int ATTACKED = 4;

        private int status;

        internal Board Board
        {
            get
            {
                return board;
            }

            set
            {
                board = value;
            }
        }

        internal Actor Hero
        {
            get
            {
                return hero;
            }

            set
            {
                hero = value;
            }
        }

        internal Actor Monster
        {
            get
            {
                return monster;
            }

            set
            {
                monster = value;
            }
        }

        public Random Random
        {
            get
            {
                return random;
            }

            set
            {
                random = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public RPGGameModel()
        {
            Random = new Random();
            Board = new Board();
            Hero = new Actor();
            Hero.Name = "Nameless Hero";
            Hero.Location = Board.GetStartPoint();
            Hero.HP = 200;
            Hero.EP = 10;

            Monster = new Actor();
            Monster.Name = "A Monstor";
            Monster.HP = 200;
            Monster.EP = 30;
            Location l = new Location(Random.Next(0, Board.GetWidth()), Random.Next(0, Board.GetHeight()));
            while(!Board.IsEmpty(l))
            {
                l = new Location(Random.Next(0, Board.GetWidth()), Random.Next(0, Board.GetHeight()));
            }
            Monster.Location= l;        
        }

        public void Update()
        {
            NotifyAll();
        }

        public void Attack()
        {
            hero.Attack(monster);
            status = ATTACKED;
            NotifyAll();
        }
        public void MoveHero(int direction)
        {
            int xx = Hero.Location.X;
            int yy = Hero.Location.Y;

            switch(direction)
            {
                case UP:
                    yy = Hero.Location.Y - 1;
                    break;
                case DOWN:
                    yy = Hero.Location.Y + 1;
                    break;
                case LEFT:
                    xx = Hero.Location.X - 1;
                    break;
                case RIGHT:
                    xx = Hero.Location.X + 1;
                    break;
            }
            Location newLoc = new Location(xx, yy);

            if (!board.IsMovableTo(newLoc))
            {
                status = CANTMOVE;
            }
            else
            {
                hero.Location = newLoc;
                if (hero.Location == monster.Location)
                {
                    status = MONSTER;
                } else if (board.IsEnded(hero.Location))
                {
                    status = ENDED;
                } else
                {
                    status = MOVED;

                }

            }
            NotifyAll();
        }
    }
}
