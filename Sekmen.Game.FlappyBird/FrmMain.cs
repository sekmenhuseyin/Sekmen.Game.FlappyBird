using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sekmen.Game.FlappyBird
{
    public partial class FrmMain : Form
    {
        private bool _jumping;
        private int _pipeSpeed = 5;
        private int _gravity = 5;
        private int _score;
        private Rectangle _bounds;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _bounds = new Rectangle(picFlappyBird.Bounds.X + 2, picFlappyBird.Bounds.Y + 2, picFlappyBird.Bounds.Width - 2, picFlappyBird.Bounds.Height - 2);
            BtnRestart_Click(sender, e);
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            lblScore.Text = @"Score: " + _score;

            picPipeBottom.Left = picPipeTop.Left -= _pipeSpeed;
            picPipeBottom2.Left = picPipeTop2.Left -= _pipeSpeed;
            picFlappyBird.Top += _gravity;

            if (picPipeTop.Left < -picPipeTop.Width)
            {
                picPipeTop.Left = picPipeBottom.Left = Width + picPipeTop.Width;
                _score++;
            }

            if (picPipeTop2.Left < -picPipeTop2.Width)
            {
                picPipeTop2.Left = picPipeBottom2.Left = Width + picPipeTop2.Width;
                _score++;
            }

            if (picFlappyBird.Bounds.IntersectsWith(picGround.Bounds) ||
                picFlappyBird.Bounds.IntersectsWith(picPipeBottom.Bounds) ||
                picFlappyBird.Bounds.IntersectsWith(picPipeTop.Bounds) ||
                picFlappyBird.Bounds.IntersectsWith(picPipeBottom2.Bounds) ||
                picFlappyBird.Bounds.IntersectsWith(picPipeTop2.Bounds))
            {
                GameEnd();
            }
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space) return;

            _jumping = true;
            _gravity = -5;
        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space) return;

            _jumping = false;
            _gravity = 5;
        }

        private void GameEnd()
        {
            timerGame.Stop();
            lblEnd2.Text = @"Your score: " + _score;
            lblEnd1.Visible = lblEnd2.Visible = btnRestart.Visible = true;
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            _score = 0;
            picPipeTop.Left = picPipeBottom.Left = Width + picPipeTop.Width;
            picPipeTop2.Left = picPipeBottom2.Left = (int)(Width * 1.7) + picPipeTop2.Width;
            lblEnd1.Visible = lblEnd2.Visible = btnRestart.Visible = false;
            picFlappyBird.Top = 0;
            timerGame.Start();
            this.Focus();
        }
    }
}
