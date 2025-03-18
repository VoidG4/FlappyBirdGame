namespace FlappyBird_1st_attempt
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
            this.MainGameTimer = new System.Windows.Forms.Timer(this.components);
            this.CreatePipesTimer = new System.Windows.Forms.Timer(this.components);
            this.Fall = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ground_pic = new System.Windows.Forms.PictureBox();
            this.pipe_top2 = new System.Windows.Forms.PictureBox();
            this.pipe_top1 = new System.Windows.Forms.PictureBox();
            this.flappy_bird = new System.Windows.Forms.PictureBox();
            this.pipe_down = new System.Windows.Forms.PictureBox();
            this.pipe_up = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_top2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_top1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGameTimer
            // 
            this.MainGameTimer.Interval = 50;
            this.MainGameTimer.Tick += new System.EventHandler(this.MainGameTimer_Tick);
            // 
            // CreatePipesTimer
            // 
            this.CreatePipesTimer.Interval = 3000;
            this.CreatePipesTimer.Tick += new System.EventHandler(this.CreatePipesTimer_Tick);
            // 
            // Fall
            // 
            this.Fall.Interval = 16;
            this.Fall.Tick += new System.EventHandler(this.Fall_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 72);
            this.label1.TabIndex = 10;
            this.label1.Text = "SCORE:0";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FlappyBird_1st_attempt.Properties.Resources.flappy_play_button1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(209, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 80);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 626);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(572, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // ground_pic
            // 
            this.ground_pic.Image = global::FlappyBird_1st_attempt.Properties.Resources.flappy_ground;
            this.ground_pic.Location = new System.Drawing.Point(-1, 607);
            this.ground_pic.Name = "ground_pic";
            this.ground_pic.Size = new System.Drawing.Size(572, 119);
            this.ground_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground_pic.TabIndex = 2;
            this.ground_pic.TabStop = false;
            // 
            // pipe_top2
            // 
            this.pipe_top2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pipe_top2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pipe_top2.Location = new System.Drawing.Point(558, 437);
            this.pipe_top2.Name = "pipe_top2";
            this.pipe_top2.Size = new System.Drawing.Size(111, 37);
            this.pipe_top2.TabIndex = 8;
            this.pipe_top2.TabStop = false;
            // 
            // pipe_top1
            // 
            this.pipe_top1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pipe_top1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pipe_top1.Location = new System.Drawing.Point(558, 181);
            this.pipe_top1.Name = "pipe_top1";
            this.pipe_top1.Size = new System.Drawing.Size(111, 37);
            this.pipe_top1.TabIndex = 9;
            this.pipe_top1.TabStop = false;
            // 
            // flappy_bird
            // 
            this.flappy_bird.Image = global::FlappyBird_1st_attempt.Properties.Resources.flappy_bird;
            this.flappy_bird.Location = new System.Drawing.Point(30, 313);
            this.flappy_bird.Name = "flappy_bird";
            this.flappy_bird.Size = new System.Drawing.Size(63, 47);
            this.flappy_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy_bird.TabIndex = 3;
            this.flappy_bird.TabStop = false;
            // 
            // pipe_down
            // 
            this.pipe_down.BackColor = System.Drawing.Color.Green;
            this.pipe_down.Image = global::FlappyBird_1st_attempt.Properties.Resources.flappy_pipe_down;
            this.pipe_down.Location = new System.Drawing.Point(562, -196);
            this.pipe_down.Name = "pipe_down";
            this.pipe_down.Size = new System.Drawing.Size(103, 414);
            this.pipe_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_down.TabIndex = 5;
            this.pipe_down.TabStop = false;
            // 
            // pipe_up
            // 
            this.pipe_up.BackColor = System.Drawing.Color.Green;
            this.pipe_up.Image = global::FlappyBird_1st_attempt.Properties.Resources.flappy_pipe;
            this.pipe_up.Location = new System.Drawing.Point(562, 440);
            this.pipe_up.Name = "pipe_up";
            this.pipe_up.Size = new System.Drawing.Size(103, 344);
            this.pipe_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_up.TabIndex = 4;
            this.pipe_up.TabStop = false;
            // 
            // cloud2
            // 
            this.cloud2.Image = global::FlappyBird_1st_attempt.Properties.Resources.flappy_cloud;
            this.cloud2.Location = new System.Drawing.Point(380, 174);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(176, 106);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud2.TabIndex = 7;
            this.cloud2.TabStop = false;
            // 
            // cloud1
            // 
            this.cloud1.Image = global::FlappyBird_1st_attempt.Properties.Resources.flappy_cloud;
            this.cloud1.Location = new System.Drawing.Point(126, 54);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(265, 132);
            this.cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud1.TabIndex = 6;
            this.cloud1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FlappyBird_1st_attempt.Properties.Resources.flappy_cloud;
            this.pictureBox2.Location = new System.Drawing.Point(288, 344);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlappyBird_1st_attempt.Properties.Resources.flappy_cloud;
            this.pictureBox1.Location = new System.Drawing.Point(181, 466);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(570, 723);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ground_pic);
            this.Controls.Add(this.pipe_top2);
            this.Controls.Add(this.pipe_top1);
            this.Controls.Add(this.flappy_bird);
            this.Controls.Add(this.pipe_down);
            this.Controls.Add(this.pipe_up);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.cloud1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_top2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_top1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ground_pic;
        private System.Windows.Forms.PictureBox flappy_bird;
        private System.Windows.Forms.PictureBox pipe_up;
        private System.Windows.Forms.PictureBox pipe_down;
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.PictureBox cloud2;
        private System.Windows.Forms.Timer MainGameTimer;
        private System.Windows.Forms.Timer CreatePipesTimer;
        private System.Windows.Forms.Timer Fall;
        private System.Windows.Forms.PictureBox pipe_top2;
        private System.Windows.Forms.PictureBox pipe_top1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}

