using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Hackathon_Spring_2021
{

    public partial class Form1 : MaterialForm
    {
        Random rand = new Random();
        bool goLeft = false;
        bool goRight = false;
        bool goUp = false;
        bool goDown = false;

        bool goLeftAllowed = true;
        bool goRightAllowed = true;
        bool goUpAllowed = true;
        bool goDownAllowed = true;
        Pokemon PokeWahl = new Pokemon("Wahl", 0, 0);
        Pokemon PokeLitman = new Pokemon("Litman", 0, 0);
        Pokemon PokeYoungLock = new Pokemon("JoshLoc", 0, 0);
        Pokemon PokeOGLock = new Pokemon("DocLoc", 0, 0);
        

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            Litman.BackColor = Color.Transparent;
            DocLoc.BackColor = Color.Transparent;

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

        private void randomizeLocation(Pokemon pokeToMove)
        {
            int x = rand.Next(100, 700);
            int y = rand.Next(100, 700);
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
    }
}
