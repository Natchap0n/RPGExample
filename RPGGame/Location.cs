using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Location
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }



        public static bool operator ==(Location l1, Location l2)
        {
            return (l1.X == l2.X && l1.Y == l2.Y);
        }

        public static bool operator !=(Location l1, Location l2)
        {
            return (l1.X != l2.X || l1.Y != l2.Y);
        }

    }
}
