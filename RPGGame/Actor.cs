using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Actor
    {
        private string name;
        private int hp;
        private int ep;
        private Location location;
        private Random random;

        public Actor()
        {
            random = new Random();
        }

        public int Attack(Actor opp)
        {
            int ap = random.Next(0, EP);
            if (opp.HP < ap) ap = opp.HP;
            opp.HP -= ap;
            EP += (int)Math.Floor(((float)ap) * ((float)random.Next(0, 100) / 100.0));

            HP -= opp.EP;
            return EP;
        }
        

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int HP
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }

        public int EP
        {
            get
            {
                return ep;
            }

            set
            {
                ep = value;
            }
        }

        public Location Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }
    }
}
