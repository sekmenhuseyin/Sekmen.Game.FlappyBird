namespace Sekmen.Game.FlappyBird
{
    partial class FrmMain
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
            this.picFlappyBird = new System.Windows.Forms.PictureBox();
            this.picPipeTop = new System.Windows.Forms.PictureBox();
            this.picPipeBottom = new System.Windows.Forms.PictureBox();
            this.picGround = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblEnd1 = new System.Windows.Forms.Label();
            this.lblEnd2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            this.SuspendLayout();
            // 
            // picFlappyBird
            // 
            this.picFlappyBird.Image = global::Sekmen.Game.FlappyBird.Properties.Resources.bird;
            this.picFlappyBird.Location = new System.Drawing.Point(12, 12);
            this.picFlappyBird.Name = "picFlappyBird";
            this.picFlappyBird.Size = new System.Drawing.Size(62, 52);
            this.picFlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlappyBird.TabIndex = 0;
            this.picFlappyBird.TabStop = false;
            // 
            // picPipeTop
            // 
            this.picPipeTop.Image = global::Sekmen.Game.FlappyBird.Properties.Resources.pipedown;
            this.picPipeTop.Location = new System.Drawing.Point(708, -161);
            this.picPipeTop.Name = "picPipeTop";
            this.picPipeTop.Size = new System.Drawing.Size(80, 248);
            this.picPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPipeTop.TabIndex = 1;
            this.picPipeTop.TabStop = false;
            // 
            // picPipeBottom
            // 
            this.picPipeBottom.Image = global::Sekmen.Game.FlappyBird.Properties.Resources.pipe;
            this.picPipeBottom.Location = new System.Drawing.Point(708, 277);
            this.picPipeBottom.Name = "picPipeBottom";
            this.picPipeBottom.Size = new System.Drawing.Size(80, 272);
            this.picPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPipeBottom.TabIndex = 2;
            this.picPipeBottom.TabStop = false;
            // 
            // picGround
            // 
            this.picGround.Image = global::Sekmen.Game.FlappyBird.Properties.Resources.ground;
            this.picGround.Location = new System.Drawing.Point(-3, 401);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(803, 50);
            this.picGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGround.TabIndex = 3;
            this.picGround.TabStop = false;
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 15;
            this.timerGame.Tick += new System.EventHandler(this.TimerGame_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblScore.Location = new System.Drawing.Point(295, 21);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(57, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "label1";
            // 
            // lblEnd1
            // 
            this.lblEnd1.AutoSize = true;
            this.lblEnd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEnd1.Location = new System.Drawing.Point(250, 138);
            this.lblEnd1.Name = "lblEnd1";
            this.lblEnd1.Size = new System.Drawing.Size(76, 25);
            this.lblEnd1.TabIndex = 5;
            this.lblEnd1.Text = "label2";
            // 
            // lblEnd2
            // 
            this.lblEnd2.AutoSize = true;
            this.lblEnd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEnd2.Location = new System.Drawing.Point(250, 174);
            this.lblEnd2.Name = "lblEnd2";
            this.lblEnd2.Size = new System.Drawing.Size(76, 25);
            this.lblEnd2.TabIndex = 6;
            this.lblEnd2.Text = "label3";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEnd2);
            this.Controls.Add(this.lblEnd1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picPipeBottom);
            this.Controls.Add(this.picPipeTop);
            this.Controls.Add(this.picFlappyBird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picFlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFlappyBird;
        private System.Windows.Forms.PictureBox picPipeTop;
        private System.Windows.Forms.PictureBox picPipeBottom;
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblEnd1;
        private System.Windows.Forms.Label lblEnd2;
    }
}

