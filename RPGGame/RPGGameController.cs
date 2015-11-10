using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class RPGGameController : Controller
    {
        public const int UP = 0;
        public const int DOWN = 1;
        public const int LEFT = 2;
        public const int RIGHT = 3;

        public const int ATTACK = 4;
        public const int RUN = 5;

        public override void ActionPerformed(int action)
        {
            foreach(Model m in mList)
            {
                if(m is RPGGameModel)
                {
                    RPGGameModel rpm = (RPGGameModel)m;
                    if(action == UP || action == DOWN || action == LEFT || action == RIGHT)
                    {
                        rpm.MoveHero(action);
                    } else if(action == ATTACK)
                    {
                        rpm.Attack();
                    } else {
                        rpm.Update();

                    }
                }
            }
        }
    }
}
