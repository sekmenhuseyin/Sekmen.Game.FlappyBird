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
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.picPipeBottom2 = new System.Windows.Forms.PictureBox();
            this.picPipeTop2 = new System.Windows.Forms.PictureBox();
            this.listScores = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.picFlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeTop2)).BeginInit();
            this.SuspendLayout();
            // 
            // picFlappyBird
            // 
            this.picFlappyBird.Image = global::Sekmen.Game.FlappyBird.Properties.Resources.bird;
            this.picFlappyBird.Location = new System.Drawing.Point(12, 12);
            this.picFlappyBird.Name = "picFlappyBird";
            this.picFlappyBird.Size = new System.Drawing.Size(62, 46);
            this.picFlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlappyBird.TabIndex = 0;
            this.picFlappyBird.TabStop = false;
            // 
            // picPipeTop
            // 
            this.picPipeTop.Image = global::Sekmen.Game.FlappyBird.Properties.Resources.pipedown;
            this.picPipeTop.Location = new System.Drawing.Point(708, -250);
            this.picPipeTop.Name = "picPipeTop";
            this.picPipeTop.Size = new System.Drawing.Size(70, 300);
            this.picPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPipeTop.TabIndex = 1;
            this.picPipeTop.TabStop = false;
            // 
            // picPipeBottom
            // 
            this.picPipeBottom.Image = global::Sekmen.Game.FlappyBird.Properties.Resources.pipe;
            this.picPipeBottom.Location = new System.Drawing.Point(708, 200);
            this.picPipeBottom.Name = "picPipeBottom";
            this.picPipeBottom.Size = new System.Drawing.Size(70, 300);
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
            this.lblScore.Size = new System.Drawing.Size(56, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score";
            this.lblScore.Visible = false;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEnd.Location = new System.Drawing.Point(250, 80);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(140, 25);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Text = "High Scores";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(245, 321);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 45);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // picPipeBottom2
            // 
            this.picPipeBottom2.Image = global::Sekmen.Game.FlappyBird.Properties.Resources.pipe;
            this.picPipeBottom2.Location = new System.Drawing.Point(469, 350);
            this.picPipeBottom2.Name = "picPipeBottom2";
            this.picPipeBottom2.Size = new System.Drawing.Size(70, 300);
            this.picPipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPipeBottom2.TabIndex = 9;
            this.picPipeBottom2.TabStop = false;
            // 
            // picPipeTop2
            // 
            this.picPipeTop2.Image = global::Sekmen.Game.FlappyBird.Properties.Resources.pipedown;
            this.picPipeTop2.Location = new System.Drawing.Point(469, -100);
            this.picPipeTop2.Name = "picPipeTop2";
            this.picPipeTop2.Size = new System.Drawing.Size(70, 300);
            this.picPipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPipeTop2.TabIndex = 8;
            this.picPipeTop2.TabStop = false;
            // 
            // listScores
            // 
            this.listScores.BackColor = System.Drawing.SystemColors.InfoText;
            this.listScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnScore});
            this.listScores.HideSelection = false;
            this.listScores.Location = new System.Drawing.Point(191, 108);
            this.listScores.Name = "listScores";
            this.listScores.Size = new System.Drawing.Size(255, 207);
            this.listScores.TabIndex = 10;
            this.listScores.UseCompatibleStateImageBehavior = false;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnScore
            // 
            this.columnScore.Text = "Score";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listScores);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picPipeBottom);
            this.Controls.Add(this.picPipeTop);
            this.Controls.Add(this.picFlappyBird);
            this.Controls.Add(this.picPipeBottom2);
            this.Controls.Add(this.picPipeTop2);
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
            ((System.ComponentModel.ISupportInitialize)(this.picPipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeTop2)).EndInit();
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
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picPipeBottom2;
        private System.Windows.Forms.PictureBox picPipeTop2;
        private System.Windows.Forms.ListView listScores;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnScore;
    }
}

