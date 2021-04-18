using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Hackathon_Spring_2021
{

    public partial class Form1 : MaterialForm
    {
        catchScreen catchScreen = new catchScreen();
        int swap = 1;
        Random rand = new Random();
        bool goLeft = false;
        bool goRight = false;
        bool goUp = false;
        bool goDown = false;

        //Wahl
        bool goLeftW = false;
        bool goRightW = false;
        bool goUpW = false;
        bool goDownW = false;

        //Litman
        bool goLeftLit = false;
        bool goRightLit = false;
        bool goUpLit = false;
        bool goDownLit = false;

        //Lil Lock
        bool goLeftLL = false;
        bool goRightLL = false;
        bool goUpLL = false;
        bool goDownLL = false;

        //Doc Loc
        bool goLeftDL = false;
        bool goRightDL = false;
        bool goUpDL = false;
        bool goDownDL = false;

        //Junk
        bool goLeftAllowed = true;
        bool goRightAllowed = true;
        bool goUpAllowed = true;
        bool goDownAllowed = true;
        Pokemon PokeWahl = new Pokemon("Wahl", 0, 0);
        Pokemon PokeLitman = new Pokemon("Litman", 0, 0);
        Pokemon PokeYoungLock = new Pokemon("JoshLoc", 0, 0);
        Pokemon PokeOGLock = new Pokemon("DocLoc", 0, 0);
        int pokeSpeed = 3;
        int bounceBack = 25;

        public Form1()
        {
            InitializeComponent();
            
            playSong();
            /*
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            */
            player.Parent = map;
            Litman.Parent = map;
            Wahl.Parent = map;
            DocLoc.Parent = map;
            JoshLoc.Parent = map;
            

            

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
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox21.Visible = false;
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
                player.Left -= 15;
            }

            if ((goRight) && (goRightAllowed))
            {
                player.Left += 15;
            }

            if ((goUp) && (goUpAllowed))
            {
                player.Top -= 15;
            }

            if ((goDown) && (goDownAllowed))
            {
                player.Top += 15;
            }

            //spawning
            /*
            int flag = 0;
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag == "wall")
                {

                    if (Wahl.Bounds.IntersectsWith(x.Bounds))
                    {
                        randomizeLocation(PokeWahl);
                        Wahl.Location = new Point(PokeWahl.LocationX, PokeWahl.LocationY);
                        flag = 0;
                    }
                    if (JoshLoc.Bounds.IntersectsWith(x.Bounds))
                    {
                        randomizeLocation(PokeYoungLock);
                        JoshLoc.Location = new Point(PokeYoungLock.LocationX, PokeYoungLock.LocationY);
                        flag = 0;
                    }
                    if (DocLoc.Bounds.IntersectsWith(x.Bounds))
                    {
                        randomizeLocation(PokeOGLock);
                        DocLoc.Location = new Point(PokeOGLock.LocationX, PokeOGLock.LocationY);
                        flag = 0;
                    }
                    if (Litman.Bounds.IntersectsWith(x.Bounds))
                    {
                        randomizeLocation(PokeLitman);
                        Litman.Location = new Point(PokeLitman.LocationX, PokeLitman.LocationY);
                        flag = 0;
                    }

                    else
                    {
                        flag = 1;
                    }

                }
            
            }
            */
           
            //players bounds
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "wall")
                {
                    if ((player.Bounds.IntersectsWith(x.Bounds)) && goRight)
                    {
                        player.Left -= 15;
                    }
                    if ((player.Bounds.IntersectsWith(x.Bounds)) && goLeft)
                    {
                        player.Left += 15;
                    }
                    if ((player.Bounds.IntersectsWith(x.Bounds)) && goUp)
                    {
                        player.Top += 15;
                    }
                    if ((player.Bounds.IntersectsWith(x.Bounds)) && goDown)
                    {
                        player.Top -= 15;
                    }
                }


                if (player.Bounds.IntersectsWith(Wahl.Bounds))
                {
                    timer1.Stop();
                    
                    catchScreen.Show();
                    this.Hide();
                }
                /*
                if ((x is PictureBox && x.Tag == "pokemon"))
                {
                    if ((player.Bounds.IntersectsWith(x.Bounds)))
                    {
                        Thread.Sleep(2000);
                        catchScreen catchScreen = new catchScreen();
                        catchScreen.ShowDialog();
                        this.Close();
                    }
                    
                }
                */
                /*if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }*/
            }
            /*
            int direction = rand.Next(1, 4);
            //1 = up, 2 = right, 3 = down, 4 = left
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "wall")
                {
                    if (direction == 1)
                    {
                        if ((player.Bounds.IntersectsWith(x.Bounds)) == false)
                        {
                            PokeWahl.LocationY -= 1;
                            Wahl.Location = new Point(PokeWahl.LocationX, PokeWahl.LocationY);
                        }
                    }
                    if (direction == 2)
                    {
                        if ((player.Bounds.IntersectsWith(x.Bounds)) == false)
                        {
                            PokeWahl.LocationX += 1;
                            Wahl.Location = new Point(PokeWahl.LocationX, PokeWahl.LocationY);
                        }
                    }
                    if (direction == 3)
                    {
                        if ((player.Bounds.IntersectsWith(x.Bounds)) == false)
                        {
                            PokeWahl.LocationY += 1;
                            Wahl.Location = new Point(PokeWahl.LocationX, PokeWahl.LocationY);
                        }
                    }
                    if (direction == 4)
                    {
                        if ((player.Bounds.IntersectsWith(x.Bounds)) == false)
                        {
                            PokeWahl.LocationX -= 1;
                            Wahl.Location = new Point(PokeWahl.LocationX, PokeWahl.LocationY);
                        }
                    }
                }
            
            }
            */

            //From Here (WAHL)
            int direction = rand.Next(1, 4);

            if ((goLeftW))
            {
                Wahl.Left -= pokeSpeed;
                goLeftW = false;
            }

            if ((goRightW))
            {
                Wahl.Left += pokeSpeed;
                goRightW = false;
            }

            if ((goUpW))
            {
                Wahl.Top -= pokeSpeed;
                goUpW = false;
            }

            if ((goDownW))
            {
                Wahl.Top += pokeSpeed;
                goUpW = false;
            }


            if (direction == 1)
            {
                goRightW = true;
            }
            if (direction == 2)
            {
                goLeftW = true;
            }
            if (direction == 3)
            {
                goUpW = true;
            }
            if (direction == 4)
            {
                goDownW = true;
            }

            //wahl bounds
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && ((x.Tag == "wall") || (x.Tag == "pokemon")))
                {
                    if ((Wahl.Bounds.IntersectsWith(x.Bounds)) && goRightW)
                    {
                        Wahl.Left -= bounceBack;
                        goRightW = false;
                    }
                    if ((Wahl.Bounds.IntersectsWith(x.Bounds)) && goLeftW)
                    {
                        Wahl.Left += bounceBack;
                        goLeftW = false;
                    }
                    if ((Wahl.Bounds.IntersectsWith(x.Bounds)) && goUpW)
                    {
                        Wahl.Top += bounceBack;
                        goUpW = false;
                    }
                    if ((Wahl.Bounds.IntersectsWith(x.Bounds)) && goDownW)
                    {
                        Wahl.Top -= bounceBack;
                        goDownW = false;
                    }
                }
                
            }
            //To Here

            //Doc Loc Starts Here

            direction = rand.Next(1, 4);

            if ((goLeftDL))
            {
                DocLoc.Left -= pokeSpeed;
                goLeftDL = false;
            }

            if ((goRightDL))
            {
                DocLoc.Left += pokeSpeed;
                goRightDL = false;
            }

            if ((goUpDL))
            {
                DocLoc.Top -= pokeSpeed;
                goUpDL = false;
            }

            if ((goDownDL))
            {
                DocLoc.Top += pokeSpeed;
                goUpDL = false;
            }


            if (direction == 1)
            {
                goRightDL = true;
            }
            if (direction == 2)
            {
                goLeftDL = true;
            }
            if (direction == 3)
            {
                goUpDL = true;
            }
            if (direction == 4)
            {
                goDownDL = true;
            }

            //Doc Loc bounds
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "wall")
                {
                    if ((DocLoc.Bounds.IntersectsWith(x.Bounds)) && goRightDL)
                    {
                        DocLoc.Left -= bounceBack;
                        goRightDL = false;
                    }
                    if ((DocLoc.Bounds.IntersectsWith(x.Bounds)) && goLeftDL)
                    {
                        DocLoc.Left += bounceBack;
                        goLeftDL = false;
                    }
                    if ((DocLoc.Bounds.IntersectsWith(x.Bounds)) && goUpDL)
                    {
                        DocLoc.Top += bounceBack;
                        goUpDL = false;
                    }
                    if ((DocLoc.Bounds.IntersectsWith(x.Bounds)) && goDownDL)
                    {
                        DocLoc.Top -= bounceBack;
                        goDownDL = false;
                    }
                }

            }

            //Litman Starts Here
            direction = rand.Next(1, 4);

            if ((goLeftLit))
            {
                Litman.Left -= pokeSpeed;
                goLeftLit = false;
            }

            if (goRightLit)
            {
                Litman.Left += pokeSpeed;
                goRightW = false;
            }

            if ((goUpW))
            {
                Litman.Top -= pokeSpeed;
                goUpLit = false;
            }

            if ((goDownLit))
            {
                Litman.Top += pokeSpeed;
                goUpLit = false;
            }


            if (direction == 1)
            {
                goRightLit = true;
            }
            if (direction == 2)
            {
                goLeftLit = true;
            }
            if (direction == 3)
            {
                goUpLit = true;
            }
            if (direction == 4)
            {
                goDownLit = true;
            }

            //Litman bounds
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "wall")
                {
                    if ((Litman.Bounds.IntersectsWith(x.Bounds)) && goRightLit)
                    {
                        Litman.Left -= bounceBack;
                        goRightLit = false;
                    }
                    if ((Litman.Bounds.IntersectsWith(x.Bounds)) && goLeftLit)
                    {
                        Litman.Left += bounceBack;
                        goLeftLit = false;
                    }
                    if ((Litman.Bounds.IntersectsWith(x.Bounds)) && goUpLit)
                    {
                        Litman.Top += bounceBack;
                        goUpLit = false;
                    }
                    if ((Litman.Bounds.IntersectsWith(x.Bounds)) && goDownLit)
                    {
                        Litman.Top -= bounceBack;
                        goDownLit = false;
                    }
                }

            }
            //Litman ends here

        }

        private void playSong()
        {
            SoundPlayer eightBit = new SoundPlayer(@"D:\csResources\Hackathons\Hackathon Spring 2021\Pokémon Theme (8 Bit Remix Cover Version) [Tribute to Pokémon] - 8 Bit Universe (1).wav");
            eightBit.Play();
        }
        private void randomizeLocation(Pokemon pokeToMove)
        {
            int x = rand.Next(0, 1920);
            int y = rand.Next(0, 1080);
            pokeToMove.LocationX = x;
            pokeToMove.LocationY = y;
        }

        
        public class Pokemon
        {

            // Constructor that takes one argument:
            public Pokemon(string name, int id, int evo)
            {
                Name = name;
                PokeID = id;
                Evolution = evo;
                LocationX = 0;
                LocationY = 0;
            }

            // Auto-implemented readonly property:
            public string Name { get; }
            public int PokeID { get; }
            public int Evolution { get; }
            public int LocationX { get; set; }         
            public int LocationY { get; set; }


        }

        private void Litman_Click(object sender, EventArgs e)
        {

        }

        private void DocLoc_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox21.Visible = false;
            this.Select();
        }
    }
}
