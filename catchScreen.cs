using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hackathon_Spring_2021
{
    public partial class catchScreen : Form
    {
        
        bool goUp = true;
        bool goDown = false;
        int counter = 0;
        public catchScreen()
        {
            InitializeComponent();
            playSong();
            pictureBox3.Parent = pictureBox7;
            pictureBox4.Parent = pictureBox7;
            pictureBox5.Parent = pictureBox7;
            pictureBox6.Parent = pictureBox7;
            congrats.Parent = pictureBox7;
            pictureBox5.Visible = false;
        }
        private void stop()
        {
            goDown = false;
            goUp = false;
        }

        private void playSong()
        {
            SoundPlayer eightBit = new SoundPlayer(@"D:\csResources\Hackathons\Hackathon Spring 2021\(DOOM Eternal OST) Rip and Tear...Until its Done - Mick Gordon but it is extended to 4 Minutes.wav");
            eightBit.Play();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (goUp)
            {
                button1.Top -= 5;
            }
            if (goDown)
            {
                button1.Top += 5;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "wall")
                {
                    if (button1.Bounds.IntersectsWith(x.Bounds) && (goUp == true))
                    {
                        button1.Top += 5;
                        goUp = false;
                        goDown = true;
                    }
                    if (button1.Bounds.IntersectsWith(x.Bounds) && (goDown == true))
                    {
                        button1.Top -= 5;
                        goUp = true;
                        goDown = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.stop();
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            Random rand = new Random();
            this.Select();
            button2.Visible = true;
            timer2.Enabled = true;

            congrats.Visible = true;
            
            //Thread.Sleep(3000);
            
           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            pictureBox5.Left += 10;
            pictureBox5.Top += 10;
            pictureBox5.Left -= 10;
            pictureBox5.Top -= 10;
            counter++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
