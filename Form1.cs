using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Hackathon_Spring_2021
{
    public partial class Form1 : MaterialForm
    {
        bool goLeft = false;
        bool goRight = false;
        bool goUp = false;
        bool goDown = false;

        bool goLeftAllowed = true;
        bool goRightAllowed = true;
        bool goUpAllowed = true;
        bool goDownAllowed = true;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }

        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((goLeft) && (goLeftAllowed))
            {
                player.Left -= 5;
            }

            if ((goRight) && (goRightAllowed))
            {
                player.Left += 5;
            }

            if ((goUp) && (goUpAllowed))
            {
                player.Top -= 5;
            }

            if ((goDown) && (goDownAllowed))
            {
                player.Top += 5;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "wall")
                {
                    if ((player.Bounds.IntersectsWith(x.Bounds)) && goRight)
                    {
                        player.Left -= 5;
                    }
                    if ((player.Bounds.IntersectsWith(x.Bounds)) && goLeft)
                    {
                        player.Left += 5;
                    }
                    if ((player.Bounds.IntersectsWith(x.Bounds)) && goUp)
                    {
                        player.Top += 5;
                    }
                    if ((player.Bounds.IntersectsWith(x.Bounds)) && goDown)
                    {
                        player.Top -= 5;
                    }
                }
                /*if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }*/
            }

        }
    }
}
