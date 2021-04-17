
namespace Hackathon_Spring_2021
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Wahl = new System.Windows.Forms.PictureBox();
            this.JoshLoc = new System.Windows.Forms.PictureBox();
            this.DocLoc = new System.Windows.Forms.PictureBox();
            this.Litman = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JoshLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Litman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.HotTrack;
            this.player.Location = new System.Drawing.Point(272, 169);
            this.player.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(38, 41);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Wahl
            // 
            this.Wahl.BackColor = System.Drawing.Color.Cyan;
            this.Wahl.Location = new System.Drawing.Point(957, 206);
            this.Wahl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Wahl.Name = "Wahl";
            this.Wahl.Size = new System.Drawing.Size(46, 41);
            this.Wahl.TabIndex = 8;
            this.Wahl.TabStop = false;
            this.Wahl.Tag = "pokemon";
            // 
            // JoshLoc
            // 
            this.JoshLoc.BackColor = System.Drawing.Color.DarkOrchid;
            this.JoshLoc.Location = new System.Drawing.Point(536, 233);
            this.JoshLoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JoshLoc.Name = "JoshLoc";
            this.JoshLoc.Size = new System.Drawing.Size(46, 41);
            this.JoshLoc.TabIndex = 9;
            this.JoshLoc.TabStop = false;
            this.JoshLoc.Tag = "pokemon";
            // 
            // DocLoc
            // 
            this.DocLoc.BackColor = System.Drawing.Color.Transparent;
            this.DocLoc.Image = ((System.Drawing.Image)(resources.GetObject("DocLoc.Image")));
            this.DocLoc.Location = new System.Drawing.Point(676, 405);
            this.DocLoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DocLoc.Name = "DocLoc";
            this.DocLoc.Size = new System.Drawing.Size(127, 109);
            this.DocLoc.TabIndex = 10;
            this.DocLoc.TabStop = false;
            this.DocLoc.Tag = "pokemon";
            // 
            // Litman
            // 
            this.Litman.BackColor = System.Drawing.Color.Transparent;
            this.Litman.Image = ((System.Drawing.Image)(resources.GetObject("Litman.Image")));
            this.Litman.Location = new System.Drawing.Point(676, 233);
            this.Litman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Litman.Name = "Litman";
            this.Litman.Size = new System.Drawing.Size(127, 115);
            this.Litman.TabIndex = 11;
            this.Litman.TabStop = false;
            this.Litman.Tag = "pokemon";
            this.Litman.Click += new System.EventHandler(this.Litman_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox7.Location = new System.Drawing.Point(957, 118);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(163, 665);
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "wall";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 650);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox2.Location = new System.Drawing.Point(37, 602);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(429, 202);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.Litman);
            this.Controls.Add(this.DocLoc);
            this.Controls.Add(this.JoshLoc);
            this.Controls.Add(this.Wahl);
            this.Controls.Add(this.player);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "S120";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyIsPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wahl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JoshLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Litman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Wahl;
        private System.Windows.Forms.PictureBox JoshLoc;
        private System.Windows.Forms.PictureBox DocLoc;
        private System.Windows.Forms.PictureBox Litman;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

