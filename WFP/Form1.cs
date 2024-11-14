using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int t = 0, Score = 0, Jelighe = 3;

        private void right_Click(object sender, EventArgs e)
        {
            int old = mando.Left;
            mando.Left += mando.Width + 6;
            if (mando.Bounds.IntersectsWith(label23.Bounds) || mando.Bounds.IntersectsWith(label27.Bounds) || mando.Bounds.IntersectsWith(label26.Bounds) || mando.Bounds.IntersectsWith(label22.Bounds) || mando.Bounds.IntersectsWith(label25.Bounds) || mando.Bounds.IntersectsWith(label24.Bounds) || mando.Bounds.IntersectsWith(label29.Bounds) || mando.Bounds.IntersectsWith(label30.Bounds) || mando.Bounds.IntersectsWith(label28.Bounds) || mando.Bounds.IntersectsWith(label33.Bounds) || mando.Bounds.IntersectsWith(label32.Bounds))
            {
                mando.Left = old;
            }
            if (mando.Bounds.IntersectsWith(yoda1.Bounds) || mando.Bounds.IntersectsWith(yoda2.Bounds))
            {
                Score += 5;
                lblScore.Text = "Score : " + Score.ToString(); ;
            }
            if (mando.Bounds.IntersectsWith(ship.Bounds))
            {
                Score -= 5;
                lblScore.Text = "Score : " + Score.ToString();
            }
            if (mando.Bounds.IntersectsWith(sit1.Bounds) || mando.Bounds.IntersectsWith(sit2.Bounds))
            {
                Score -= 10;
                lblScore.Text = "Score : " + Score.ToString();
                Jelighe -= 1;
                lblJelighe.Text= "life jacket: " + Jelighe.ToString();
                if (Jelighe == 0)
                {
                    MessageBox.Show("Loser !", "No!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    t = 0;
                    Jelighe = 3;
                    Score = 0;
                    mando.Location = new Point(183,306);
                    lblScore.Text = "Score : " + Score.ToString();
                    lblJelighe.Text = "life jacket: " + Jelighe.ToString();
                }
            }

        }

        private void up_Click(object sender, EventArgs e)
        {
            int old = mando.Top;
            mando.Top -= mando.Height + 5;
            if (mando.Bounds.IntersectsWith(label6.Bounds) || mando.Bounds.IntersectsWith(label7.Bounds) || mando.Bounds.IntersectsWith(label11.Bounds) || mando.Bounds.IntersectsWith(label12.Bounds) || mando.Bounds.IntersectsWith(label13.Bounds) || mando.Bounds.IntersectsWith(label14.Bounds) || mando.Bounds.IntersectsWith(label33.Bounds) || mando.Bounds.IntersectsWith(label28.Bounds) || mando.Bounds.IntersectsWith(label32.Bounds) || mando.Bounds.IntersectsWith(label29.Bounds) || mando.Bounds.IntersectsWith(label31.Bounds))
            {
                mando.Top = old;
            }
            if (mando.Bounds.IntersectsWith(yoda1.Bounds) || mando.Bounds.IntersectsWith(yoda2.Bounds))
            {
                Score += 5;
                lblScore.Text = "Score : " + Score.ToString(); ;
            }
            if (mando.Bounds.IntersectsWith(ship.Bounds))
            {
                Score -= 5;
                lblScore.Text = "Score : " + Score.ToString();
            }
            if (mando.Bounds.IntersectsWith(sit1.Bounds) || mando.Bounds.IntersectsWith(sit2.Bounds))
            {
                Score -= 10;
                lblScore.Text = "Score : " + Score.ToString();
                Jelighe -= 1;
                lblJelighe.Text = "life jacket: " + Jelighe.ToString();
                if (Jelighe == 0)
                {
                    MessageBox.Show("Loser !", "No!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    t = 0;
                    Jelighe = 3;
                    Score = 0;
                    mando.Location = new Point(183, 306);
                    lblScore.Text = "Score : " + Score.ToString();
                    lblJelighe.Text = "life jacket: " + Jelighe.ToString();
                }
            }

        }

        private void left_Click(object sender, EventArgs e)
        {
            int old = mando.Left;
            mando.Left -= mando.Width + 6;
            if (mando.Bounds.IntersectsWith(label10.Bounds) || mando.Bounds.IntersectsWith(label9.Bounds) || mando.Bounds.IntersectsWith(label8.Bounds) || mando.Bounds.IntersectsWith(label3.Bounds) || mando.Bounds.IntersectsWith(label4.Bounds) || mando.Bounds.IntersectsWith(label2.Bounds) || mando.Bounds.IntersectsWith(label33.Bounds) || mando.Bounds.IntersectsWith(label28.Bounds) || mando.Bounds.IntersectsWith(label32.Bounds) || mando.Bounds.IntersectsWith(label30.Bounds) || mando.Bounds.IntersectsWith(label31.Bounds))
            {
                mando.Left = old;
            }
            if (mando.Bounds.IntersectsWith(yoda1.Bounds) || mando.Bounds.IntersectsWith(yoda2.Bounds))
            {
                Score += 5;
                lblScore.Text = "Score : " + Score.ToString(); ;
            }
            if (mando.Bounds.IntersectsWith(ship.Bounds))
            {
                Score -= 5;
                lblScore.Text = "Score : " + Score.ToString();
            }
            if (mando.Bounds.IntersectsWith(sit1.Bounds) || mando.Bounds.IntersectsWith(sit2.Bounds))
            {
                Score -= 10;
                lblScore.Text = "Score : " + Score.ToString();
                Jelighe -= 1;
                lblJelighe.Text = "life jacket: " + Jelighe.ToString();
                if (Jelighe == 0)
                {
                    MessageBox.Show("Loser !", "No!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    t = 0;
                    Jelighe = 3;
                    Score = 0;
                    mando.Location = new Point(183, 306);
                    lblScore.Text = "Score : " + Score.ToString();
                    lblJelighe.Text = "life jacket: " + Jelighe.ToString();
                }
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            t = 0;
            Jelighe = 3;
            Score = 0;
            mando.Location = new Point(183, 306);
            lblScore.Text = "Score : " + Score.ToString();
            lblJelighe.Text = "life jacket: " + Jelighe.ToString();
        }

        private void Restart_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(lblScore.Text,"End !", MessageBoxButtons.OK,MessageBoxIcon.Information);
            t = 0;
            Jelighe = 3;
            Score = 0;
            mando.Location = new Point(183, 306);
            lblScore.Text = "Score : " + Score.ToString();
            lblJelighe.Text = "life jacket: " + Jelighe.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += 1;
            if (t == 60)
            {
                t = 0;
                MessageBox.Show("Loser !", "No!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label34.Text = t.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void down_Click(object sender, EventArgs e)
        {
            int old = mando.Top;
            mando.Top += mando.Height + 5;
            if (mando.Bounds.IntersectsWith(label15.Bounds) || mando.Bounds.IntersectsWith(label16.Bounds) || mando.Bounds.IntersectsWith(label17.Bounds) || mando.Bounds.IntersectsWith(label18.Bounds) || mando.Bounds.IntersectsWith(label19.Bounds) || mando.Bounds.IntersectsWith(label20.Bounds) || mando.Bounds.IntersectsWith(label32.Bounds) || mando.Bounds.IntersectsWith(label28.Bounds) || mando.Bounds.IntersectsWith(label30.Bounds) || mando.Bounds.IntersectsWith(label31.Bounds))
            {
                mando.Top = old;
            }
            if (mando.Bounds.IntersectsWith(yoda1.Bounds) || mando.Bounds.IntersectsWith(yoda2.Bounds))
            {
                Score += 5;
                lblScore.Text = "Score : " + Score.ToString(); ;
            }
            if (mando.Bounds.IntersectsWith(ship.Bounds))
            {
                Score -= 5;
                lblScore.Text = "Score : " + Score.ToString();
            }
            if (mando.Bounds.IntersectsWith(sit1.Bounds) || mando.Bounds.IntersectsWith(sit2.Bounds))
            {
                Score -= 10;
                lblScore.Text = "Score : " + Score.ToString();
                Jelighe -= 1;
                lblJelighe.Text = "life jacket: " + Jelighe.ToString();
                if (Jelighe == 0)
                {
                    MessageBox.Show("Loser !", "No !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Jelighe = 3;
                    Score = 0;
                    mando.Location = new Point(183, 306);
                    lblScore.Text = "Score : " + Score.ToString();
                    lblJelighe.Text = "life jacket: " + Jelighe.ToString();
                }
            }
        }
    }
}
