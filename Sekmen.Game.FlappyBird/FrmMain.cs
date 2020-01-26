using System;
using System.Windows.Forms;

namespace Sekmen.Game.FlappyBird
{
    public partial class FrmMain : Form
    {
        private bool _jumping;
        private int _pipeSpeed = 5;
        private int _gravity = 5;
        private int _score;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblEnd1.Text = @"Game Over";
            lblEnd1.Visible = lblEnd2.Visible = btnRestart.Visible = false;
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            lblScore.Text = @"Score: " + _score;

            picPipeBottom.Left -= _pipeSpeed;
            picPipeTop.Left -= _pipeSpeed;
            picFlappyBird.Top += _gravity;

            if (picPipeTop.Left < -picPipeTop.Width)
            {
                picPipeTop.Left = picPipeBottom.Left = Width + picPipeTop.Width;
                _score++;
            }

            if (picFlappyBird.Bounds.IntersectsWith(picGround.Bounds) ||
                picFlappyBird.Bounds.IntersectsWith(picPipeBottom.Bounds) ||
                picFlappyBird.Bounds.IntersectsWith(picPipeTop.Bounds))
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
            lblEnd1.Visible = lblEnd2.Visible = btnRestart.Visible = false;
            picFlappyBird.Top = 0;
            timerGame.Start();
        }
    }
}
