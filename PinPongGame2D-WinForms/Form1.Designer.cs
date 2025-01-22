﻿namespace PinPongGame2D_WinForms
{
    partial class gameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            playGround = new Panel();
            gameover_Lbl = new Label();
            points_Lbl = new Label();
            score_Lbl = new Label();
            ball = new PictureBox();
            racket = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)racket).BeginInit();
            SuspendLayout();
            // 
            // playGround
            // 
            playGround.Controls.Add(gameover_Lbl);
            playGround.Controls.Add(points_Lbl);
            playGround.Controls.Add(score_Lbl);
            playGround.Controls.Add(ball);
            playGround.Controls.Add(racket);
            playGround.Dock = DockStyle.Fill;
            playGround.Location = new Point(0, 0);
            playGround.Name = "playGround";
            playGround.Size = new Size(800, 450);
            playGround.TabIndex = 0;
            // 
            // gameover_Lbl
            // 
            gameover_Lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameover_Lbl.Location = new Point(340, 39);
            gameover_Lbl.Name = "gameover_Lbl";
            gameover_Lbl.Size = new Size(138, 69);
            gameover_Lbl.TabIndex = 4;
            gameover_Lbl.Text = "Game Over!\r\nF1-Restart Game\r\nESC-Exit\r\n";
            // 
            // points_Lbl
            // 
            points_Lbl.AutoSize = true;
            points_Lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic);
            points_Lbl.ForeColor = Color.Black;
            points_Lbl.Location = new Point(134, 29);
            points_Lbl.Name = "points_Lbl";
            points_Lbl.Size = new Size(38, 45);
            points_Lbl.TabIndex = 3;
            points_Lbl.Text = "0";
            points_Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // score_Lbl
            // 
            score_Lbl.AutoSize = true;
            score_Lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic);
            score_Lbl.ForeColor = Color.Crimson;
            score_Lbl.Location = new Point(28, 29);
            score_Lbl.Name = "score_Lbl";
            score_Lbl.Size = new Size(118, 45);
            score_Lbl.TabIndex = 2;
            score_Lbl.Text = "Score :";
            // 
            // ball
            // 
            ball.BackColor = Color.Crimson;
            ball.Location = new Point(398, 185);
            ball.Name = "ball";
            ball.Size = new Size(10, 10);
            ball.TabIndex = 1;
            ball.TabStop = false;
            // 
            // racket
            // 
            racket.BackColor = Color.Black;
            racket.Location = new Point(352, 396);
            racket.Name = "racket";
            racket.Size = new Size(100, 12);
            racket.TabIndex = 0;
            racket.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // gameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playGround);
            Name = "gameForm";
            Text = "Ping Pong Game";
            KeyDown += gameForm_KeyDown;
            playGround.ResumeLayout(false);
            playGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)racket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel playGround;
        private PictureBox racket;
        private PictureBox ball;
        private Label points_Lbl;
        private Label score_Lbl;
        private Label gameover_Lbl;
        private System.Windows.Forms.Timer timer1;
    }
}
