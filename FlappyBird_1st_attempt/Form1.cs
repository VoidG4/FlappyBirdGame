using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace FlappyBird_1st_attempt
{
    public partial class Form1 : Form
    {
        List<PictureBox> pipes = new List<PictureBox>();
        Point startPipeUp, startPipeDown, startTop1, startTop2, startLocation;
        bool lost;
        int score = -1, speed = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void resetGame()
        {
            foreach (PictureBox pipe in pipes) 
            { 
                Controls.Remove(pipe);
            }
            pipes.Clear();
            pipe_up.Location = startPipeUp;
            pipe_down.Location = startPipeDown;
            pipe_top1.Location = startTop1;
            pipe_top2.Location = startTop2;

            Controls.AddRange( new PictureBox[] { pipe_up, pipe_down, pipe_top1, pipe_top2 } );

            pipes.AddRange(new PictureBox[] { pipe_up, pipe_down, pipe_top1, pipe_top2 });

            flappy_bird.Location = startLocation;
            lost = false;
            score = 0;

            pipe_up.BringToFront();
            pipe_down.BringToFront();

            pipe_top1.BringToFront();
            pipe_top2.BringToFront();

            ground_pic.BringToFront();
            pictureBox3.BringToFront();
            label1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startLocation = flappy_bird.Location;

            startPipeUp = pipe_up.Location;
            startPipeDown = pipe_down.Location;

            startTop1 = pipe_top1.Location;
            startTop2 = pipe_top2.Location;

            pipes.AddRange(new PictureBox[] { pipe_up, pipe_down, pipe_top1, pipe_top2 });
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            button1.Visible = false;
            if (!lost)
            {
                MainGameTimer.Start();
                CreatePipesTimer.Start();
            }
            
            if (e.KeyCode == Keys.Space)
            {
                if (!lost)
                {
                    flappy_bird.Image = Properties.Resources.flappy_up;
                    flappy_bird.Top -= 100;
                    Fall.Start();
                }
            }
        }

        private void MainGameTimer_Tick(object sender, EventArgs e)
        {
            foreach(PictureBox pipe in pipes)
            {
               pipe.Left -= speed;
            }
            if (score == -1)
            {
                label1.Text = "SCORE:0";
            }
            else
            {
                label1.Text = "SCORE:" + score;
            }
            check_lost();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lost)
            {
                resetGame();
                button1.Visible = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            flappy_bird.Image = Properties.Resources.flappy_down;
        }

        private void check_lost()
        {
            if (flappy_bird.Top <= 0 || flappy_bird.Bounds.IntersectsWith(ground_pic.Bounds))
            {
                lost = true;
            }

            foreach (PictureBox pipe in pipes)
            {
                if (flappy_bird.Bounds.IntersectsWith(pipe.Bounds)) 
                {
                    lost = true;
                    break;
                }
            }

            if (lost)
            {
                MainGameTimer.Stop();
                CreatePipesTimer.Stop();
                Fall.Stop();
                DialogResult result = MessageBox.Show("You lost!");

                if (result == DialogResult.OK)
                {
                    button1.Visible = true;
                }
            }
        }

        private void CreatePipesTimer_Tick(object sender, EventArgs e)
        {
            Point temp1 = startPipeUp, temp2 = startPipeDown, temp3 = startTop1, temp4 = startTop2;

            Random random = new Random();
            Random random2 = new Random();
            int randomIndex = random.Next(0, 5);
            int randomIndex2 = random2.Next(1, 3);

            int index;
            if (score <= 10)
            {
                index = 20;
            }
            else 
            {
                index = 30;
            }

            if (randomIndex2 == 1)
            {
                startPipeUp.Y -= randomIndex * index;
                startPipeDown.Y -= randomIndex * index;
                startTop1.Y -= randomIndex * index;
                startTop2.Y -= randomIndex * index;
            }
            else if (randomIndex2 == 2)
            {
                startPipeUp.Y += randomIndex * index;
                startPipeDown.Y += randomIndex * index;
                startTop1.Y += randomIndex * index;
                startTop2.Y += randomIndex * index;
            }

            PictureBox new_pipe_up = new PictureBox();
            new_pipe_up.Image = Properties.Resources.flappy_pipe;
            new_pipe_up.Location = startPipeUp;
            new_pipe_up.Size = new Size(89, 210);
            new_pipe_up.SizeMode = PictureBoxSizeMode.StretchImage;
            new_pipe_up.Height = pipe_up.Height;
            new_pipe_up.Width = pipe_up.Width;
            
            PictureBox new_pipe_down = new PictureBox();
            new_pipe_down.Image = Properties.Resources.flappy_pipe_down;
            new_pipe_down.Location = startPipeDown;
            new_pipe_down.Size = new Size(80, 207);
            new_pipe_down.SizeMode = PictureBoxSizeMode.StretchImage;
            new_pipe_down.Height = pipe_down.Height;
            new_pipe_down.Width = pipe_down.Width;

            PictureBox new_pipe_top1 = new PictureBox();
            new_pipe_top1.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            new_pipe_top1.BorderStyle = BorderStyle.FixedSingle;
            new_pipe_top1.Location = startTop1;
            new_pipe_top1.Size = new Size(108, 23);
            new_pipe_top1.Height = pipe_top1.Height;
            new_pipe_top1.Width = pipe_top1.Width;

            PictureBox new_pipe_top2 = new PictureBox();
            new_pipe_top2.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            new_pipe_top2.BorderStyle = BorderStyle.FixedSingle;
            new_pipe_top2.Location = startTop2;
            new_pipe_top2.Size = new Size(108, 23);
            new_pipe_top2.Height = pipe_top2.Height;
            new_pipe_top2.Width = pipe_top2.Width;

            this.Controls.Add(new_pipe_up);
            this.Controls.Add(new_pipe_down);
            this.Controls.Add(new_pipe_top1);
            this.Controls.Add(new_pipe_top2);

            new_pipe_up.BringToFront();
            new_pipe_down.BringToFront();
            new_pipe_top1.BringToFront();
            new_pipe_top2.BringToFront();

            ground_pic.BringToFront();
            pictureBox3.BringToFront();
            label1.BringToFront();
            pipes.AddRange(new PictureBox[] { new_pipe_up, new_pipe_down, new_pipe_top1, new_pipe_top2});

            startPipeUp = temp1;
            startPipeDown = temp2;
            startTop1 = temp3;
            startTop2 = temp4;
            score++;
        }

        private void Fall_Tick(object sender, EventArgs e)
        {
            flappy_bird.Top += 5;
        }
    }
}
