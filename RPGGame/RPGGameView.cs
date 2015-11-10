using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGame
{
    public partial class RPGGameView : Form, View
    {
        private RPGGameController gameController;
        private RPGGameModel gameModel;
        PictureBox[,] pb;
        Image tree;
        Image wall;
        Image empty;
        Image hero;
        Image monster;
        Image start;
        Image end;


        public RPGGameView()
        {
            InitializeComponent();
            pb = new PictureBox[12, 13];
            for (int i = 0; i != 12; i++)
            {
                for (int j = 0; j != 13; j++)
                {
                    pb[i, j] = new PictureBox();
                    pb[i, j].Width = 30;
                    pb[i, j].Height = 30;
                    pb[i, j].Left = i * 30;
                    pb[i, j].Top = j * 30;
                    pb[i, j].Visible = true;
                    this.Controls.Add(pb[i, j]);
                }
            }

            tree = Image.FromFile("../../tree.png");
            wall = Image.FromFile("../../wall.png");
            empty = Image.FromFile("../../empty.png");
            hero = Image.FromFile("../../hero.png");
            monster = Image.FromFile("../../monster.png");
            start = Image.FromFile("../../start.png");
            end = Image.FromFile("../../end.png");

            gameController = new RPGGameController();
            gameModel = new RPGGameModel();
            gameController.AddModel(gameModel);
            gameModel.AttachObserver(this);
            this.setController(gameController);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameController.ActionPerformed(99);
        }


        public void setController(RPGGameController c)
        {
            gameController = c;
        }

        public void Notify(Model m)
        {
            RPGGameModel rpm = (RPGGameModel)m;
            Board board = rpm.Board;
            for(int i= 0; i != 12; i++)
            {
                for (int j = 0; j != 13; j++)
                {
                    switch (board.At(new RPGGame.Location(i, j)))
                    {
                        case Board.TREE:
                            pb[i, j].Image = tree;
                            break;
                        case Board.WALL:
                            pb[i, j].Image = wall;
                            break;
                        case Board.END:
                            pb[i, j].Image = end;
                            break;
                        case Board.START:
                            pb[i, j].Image = start;
                            break;
                        default:
                            pb[i, j].Image = empty;
                            break;
                    }
                }
            }
            pb[rpm.Hero.Location.X, rpm.Hero.Location.Y].Image = hero;
            pb[rpm.Monster.Location.X, rpm.Monster.Location.Y].Image = monster;

            lblMsg.Text = "Where to go Next?";
            btnAttack.Enabled = false;
            if (rpm.Status == RPGGameModel.CANTMOVE)
            {
                lblMsg.Text = rpm.Hero.Name + ", you can't move there!!";
            }
            if(rpm.Status == RPGGameModel.ATTACKED)
            {
                if(rpm.Hero.HP <= 0)
                {
                    lblMsg.Text = rpm.Hero.Name + ", you dead!!!";
                }  else
                {
                    btnAttack.Enabled = true;
                    lblMsg.Text = rpm.Hero.Name + ", you meet " + rpm.Monster.Name + ". \nYou can attack!!";


                }
                if (rpm.Monster.HP <= 0)
                {
                    lblMsg.Text = rpm.Hero.Name + ", you kill that \nlittle cute animal!!";

                } 
            }
            if (rpm.Status == RPGGameModel.ENDED)
            {
                lblMsg.Text = rpm.Hero.Name + ", you found the end point!! \n(but not the end of the game, ha ha )";
            }
            if (rpm.Status == RPGGameModel.MONSTER && rpm.Hero.HP > 0)
            {
                btnAttack.Enabled = true;
                lblMsg.Text = rpm.Hero.Name + ", you meet " + rpm.Monster.Name + ". You can attack!!";
            } 
            lblHP.Text = rpm.Hero.HP.ToString();
            lblEP.Text = rpm.Hero.EP.ToString();
        } 

        private void btnUp_Click(object sender, EventArgs e)
        {
            gameController.ActionPerformed(RPGGameController.UP);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

            gameController.ActionPerformed(RPGGameController.LEFT);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {

            gameController.ActionPerformed(RPGGameController.RIGHT);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {

            gameController.ActionPerformed(RPGGameController.DOWN);
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            gameController.ActionPerformed(RPGGameController.ATTACK);
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
